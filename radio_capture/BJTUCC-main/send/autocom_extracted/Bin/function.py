# function.py
import sys
import os
import socket
import time
import json  # 添加缺失的导入
from datetime import datetime
import logging

def getTimestamp():
    """获取毫秒级 Unix 时间戳"""
    return int(datetime.now().timestamp() * 1000)

# 全局变量
client_socket = None

def open_socket(server_ip='localhost', server_port=39005):
    global client_socket  # 声明使用全局变量
    try:
        client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        client_socket.connect((server_ip, server_port))
    except socket.error as e:
        print(f"Socket error: {e}")
        if 'client_socket' in locals():
            client_socket.close()
			
def sendInit(device_count, channel_count):
	msg_dict = {
				"DeviceCount": device_count,
				"ChannelCount": channel_count,
				"BaudRate": "500kbps(87.5%),500kbps(87.5%),(60,0F800601,0F800601)"
			}
	sendMSG("init", msg_dict)
	
def sendUnInit():
	sendMSG("uninit", "")

def sendCanCmd(device_id, can_channel, cmd_id, can_fd, msg_content):
	msg_dict = {
				"DeviceID": device_id,
				"CANChannel": can_channel,
				"CmdID": cmd_id,
				"MsgContent": msg_content,
				"CANFD": can_fd
			}
	sendMSG("send", msg_dict)
		
def sendMSG(msg_type, message):
    global client_socket  # 声明使用全局变量
    if client_socket:
        try:
            msg_dict = {
                "time": getTimestamp(),
                "type": msg_type,
                "message": message
            }
            json_message = json.dumps(msg_dict, ensure_ascii=False) + '\n'
            client_socket.sendall(json_message.encode('utf-8'))
            print(f"Sent: {json_message.strip()}")
        except Exception as e:
            print(f"Send error: {e}")
    else:
        print("Socket not initialized. Call initialize_socket() first.")

def close_socket():
    global client_socket
    try:
        if client_socket:
            client_socket.close()
            print("Socket closed" if client_socket.fileno() == -1 else "Close failed")
    except Exception as e:
        print(f"Close error: {e}")