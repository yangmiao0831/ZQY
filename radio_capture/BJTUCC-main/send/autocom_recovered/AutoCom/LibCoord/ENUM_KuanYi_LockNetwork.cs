using LibUtils;

namespace LibCoord;

public enum ENUM_KuanYi_LockNetwork
{
	[MyDescription("自动(GSM->NB->EMTC)", "Auto(GSM->NB->EMTC)")]
	AutoG_N_E = 2,
	[MyDescription("仅GSM", "GSM Only")]
	GSMOnly = 3,
	[MyDescription("仅LTE", "LTE Only")]
	LTEOnly = 5,
	[MyDescription("仅GSM和LTE", "GSM and LTE Only")]
	GSMLTEOnly = 8,
	[MyDescription("自动(EMTC->NB->GSM)", "Auto(EMTC->NB->GSM)")]
	AutoE_N_G = 11,
	[MyDescription("自动(NB->EMTC->GSM)", "Auto(NB->EMTC->GSM)")]
	AutoN_E_G = 12
}
