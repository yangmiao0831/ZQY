# -*- encoding=utf8 -*-
import sys
import os
import ctypes
import time
from threading import Timer
# 添加当前目录到路径
sys.path.append(os.path.dirname(os.path.abspath(__file__)))
# 引入function.py文件
from function import *


class HongQiCANAdmin:
    def __init__(self):
        self.crc = 0x00
        self.cb_CRC_POLY = 0x1D
        self.Alive0_vehspeed = 0x00
        self.CRC0_vehspeed = 0x00
        self.DataCANFD_vehspeed = bytearray(33)
        self.cishu = 0
        self.flag = 0
        self.doorflag = 0
        self.re = 0
        
        # Initialize timers
        self.vehspeedCANFDtimer = None
        self.nmtimer = None
        self.doortimer = None
        self.waitwakeup = None
        
        # Message buffers
        self.IBC1_CANFD = bytearray(32)
        self.NVMsg = None
        self.DoorMsg = None
        self.MiddleCANNMMsg = None

    def CheckSum_VehicleSpeedCANFD(self, data):
        self.crc = 0x00
        for byte in data:
            self.crc ^= byte
            for _ in range(8):
                if (self.crc & 0x80) != 0:
                    self.crc = ((self.crc << 1) ^ self.cb_CRC_POLY) & 0xFF
                else:
                    self.crc = (self.crc << 1) & 0xFF
        return self.crc ^ 0x00

    def OnVehSpeedCANFDTimer(self):
        self.IBC1_CANFD = bytearray([
            0x00, 0x6F, 0x04, 0xE1, 0x84, 0x9E, 0x25, 0x00,
            0xFF, 0x0F, 0x30, 0x00, 0x01, 0x80, 0x01, 0x80,
            0x01, 0x80, 0x01, 0x80, 0x00, 0x02, 0x00, 0xC2,
            0xE7, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 
            (self.Alive0_vehspeed << 4) & 0xFF  # livecounter
        ])
        
        # Copy data for CRC calculation
        self.DataCANFD_vehspeed[0] = 0xC1
        self.DataCANFD_vehspeed[1] = 0x00
        for rr in range(31):
            self.DataCANFD_vehspeed[rr + 2] = self.IBC1_CANFD[rr + 1]
        
        # Calculate CRC
        self.CRC0_vehspeed = self.CheckSum_VehicleSpeedCANFD(self.DataCANFD_vehspeed)
        self.IBC1_CANFD[0] = self.CRC0_vehspeed
        
        try:
            sendCanCmd(0, 0, 0xC1, True, list(self.IBC1_CANFD))  # IBC1_CANFD, Send CAN message
            print("Sent IBC1_CANFD message")
        except can.CanError as e:
            print(f"Error sending message: {e}")
        
        self.cishu += 1
        if self.Alive0_vehspeed == 0xE:
            self.Alive0_vehspeed = 0
        else:
            self.Alive0_vehspeed += 1
        
        if self.cishu < 150:
            self.vehspeedCANFDtimer = Timer(0.001, self.OnVehSpeedCANFDTimer)
            self.vehspeedCANFDtimer.start()

    def OnNMTimer(self):
        if self.NVMsg is None:
            self.NVMsg = bytearray([0x08, 0x00, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00])

        try:
            sendCanCmd(0, 0, 0x588, False, list(self.NVMsg))  # NVMsg
            print("Sent NM message")
        except can.CanError as e:
            print(f"Error sending NM message: {e}")
        
        # Restart timer
        self.nmtimer = Timer(0.1, self.OnNMTimer)
        self.nmtimer.start()

    def OnDoorTimer(self):
        self.doorflag += 1
        if self.DoorMsg is None:
            self.DoorMsg = bytearray([0x05, 0x00, 0x02, 0x01, 0x00, 0x00, 0x00, 0xF0])
            self.MiddleCANNMMsg = bytearray([0x08, 0x00, 0x02, 0x01, 0x00, 0x00, 0x00, 0x00])
        
        try:
            sendCanCmd(0, 1, 0x24A, False, list(self.DoorMsg))  # Send Door message
            sendCanCmd(0, 1, 0x572, False, list(self.MiddleCANNMMsg))  # Send MiddleCAN NM message
            print("Sent Door and MiddleCAN NM messages")
        except can.CanError as e:
            print(f"Error sending door messages: {e}")
        
        if self.doorflag <= 30:
            self.doortimer = Timer(0.1, self.OnDoorTimer)
            self.doortimer.start()

    def OnWaitWakeupTimer(self):
        self.re += 1
        self.flag = 1
        self.DovehspeedCANFD()
        if self.re <= 1:
            self.waitwakeup = Timer(3.0, self.OnWaitWakeupTimer)
            self.waitwakeup.start()

    def StartTest(self):
        self.cishu = 0
        self.waitwakeup = Timer(3.0, self.OnWaitWakeupTimer)
        self.waitwakeup.start()

    def NM(self):
        self.nmtimer = Timer(0.1, self.OnNMTimer)
        self.nmtimer.start()

    def DoorSt(self):
        self.doortimer = Timer(0.1, self.OnDoorTimer)
        self.doortimer.start()

    def OnKeyA(self):
        self.NM()
        self.StartTest()
        self.DoorSt()
        self.re = 0

    def DovehspeedCANFD(self):
        if self.flag == 1:
            self.Alive0_vehspeed = (self.IBC1_CANFD[31] >> 4) & 0x0F
            self.Alive0_vehspeed = (self.Alive0_vehspeed + 1) & 0x0F
            self.vehspeedCANFDtimer = Timer(0.001, self.OnVehSpeedCANFDTimer)
            self.vehspeedCANFDtimer.start()
            self.flag = 0

			

# 示例用法
if __name__ == "__main__":
    # script content
    print("start...")
    #开启socket
    open_socket()
    #####user begin########
    sendInit(1, 2)
    time.sleep(1)  #单位是秒

    can_admin = HongQiCANAdmin()
    can_admin.OnKeyA()
    
    print("Do While...")
    timeout = 20  # 20秒超时
    start_time = time.time()
    try:
        while time.time() - start_time < timeout:
            time.sleep(1)
    except KeyboardInterrupt:
        print("Exiting...")
    
    print("While End...")
	#####user end########
    #关闭socket
    sendUnInit()
    #关闭socket
    close_socket()