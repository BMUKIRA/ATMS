#define Bad_USBOpen -101//�˿ڴ򿪴�.
#define Bad_USBClose -105//�˿ڹرմ�.

#define ERR		-1
#define OK		0

#define ERRCARD	2
#define ERRRDCARD	3
#define ERRWRCARD	4
#define ERRCARDSEC	5
#define ERRCARDKEY	6
#define ERRCARDLOCKED 7
#define ERRMSG 8
#define ERRRFCARD	9
#define ERRFORMAT	10
#define ERROVERFLOW	11

#define NOCARD	1
#define UNKNOWCARD	12
#define ERRCARDPOSITION	14


#define PAC_ADDRESS	1021

#define ENQ  0x05//��������ͨ����·(ѯ��).
#define ACK  0x06//ȷ��(����).
#define NAK  0x15//ͨ��æ.
#define EOT  0x04//ͨ�Ž���(���ͽ���).
#define CAN  0x18//���ͨ��(ȡ��).
#define STX  0x02//���ݰ���ʼ��(��ʼ�ַ�).
#define ETX  0x03//���ݰ�������(�ս��).
#define US   0x1F//���ݷָ���.

int APIENTRY GetSysVerion(HANDLE ComHandle, char *strVerion);
//=========================CRT-284 RS232 ===================================================
HANDLE APIENTRY CommOpen(char *Port);
HANDLE APIENTRY CommOpenWithBaut(char *Port, unsigned int _data);
int APIENTRY CommClose(HANDLE ComHandle);
int APIENTRY CommSetting(HANDLE ComHandle,char *ComSeting);
int APIENTRY CRT_R_SetComm(HANDLE ComHandle, unsigned int _data);
////////////////////////////////////////////////////////////////////////////////////////
int APIENTRY CRT284_Reset(HANDLE ComHandle);
int APIENTRY CRT284_ReadSnr(HANDLE ComHandle, BYTE _SNData[], BYTE *_dataLen);
int APIENTRY CRT284_WriteSnr(HANDLE ComHandle, BYTE _SNData[], BYTE _dataLen);
int APIENTRY CRT284_GetStatus(HANDLE ComHandle, BYTE *_bATR);

int APIENTRY CRT284_MCSetting(HANDLE ComHandle, BYTE _mode, BYTE _ctrl, BYTE _readMode, BYTE _track);
int APIENTRY CRT284_MCClear(HANDLE ComHandle);
int APIENTRY MC_ReadTrack(HANDLE ComHandle, BYTE _mode, BYTE _track, int *_BlockDataLen,BYTE _BlockData[]);
////////////////////////////////////////////////////////////////////////////////////////
int APIENTRY IC_CardOpen(HANDLE ComHandle);//���ݾɰ�,�ο�CRT_IC_CardOpen
int APIENTRY IC_CardClose(HANDLE ComHandle);//���ݾɰ�,�ο�CRT_IC_CardClose
int APIENTRY CRT_R1_DetectCard(HANDLE ComHandle,BYTE *_CardType,BYTE *_CardInfor);//���ݾɰ�,�ο�CRT_R_DetectCard

int APIENTRY CRT_IC_CardOpen(HANDLE ComHandle);//�£��滻IC_CardOpen
int APIENTRY CRT_IC_CardClose(HANDLE ComHandle);//�£��滻IC_CardClose
int APIENTRY CRT_R_DetectCard(HANDLE ComHandle,BYTE *_CardType,BYTE *_CardInfor);//�£��滻CRT_R_DetectCard

int APIENTRY RF_DetectCard(HANDLE ComHandle);
int APIENTRY RF_GetCardID(HANDLE ComHandle, BYTE *_CardIDLen, BYTE _CardID[]);
int APIENTRY RF_ChangeSecKey(HANDLE ComHandle, BYTE _Sec, BYTE _KEYLen, BYTE _KEY[]);
int APIENTRY RF_LoadSecKey(HANDLE ComHandle, BYTE _Sec, BYTE _KEYType, BYTE _KEYLen, BYTE _KEY[]);
int APIENTRY RF_ReadBlock(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE *_BlockDataLen, BYTE _BlockData[]);
int APIENTRY RF_ChangeSecKey(HANDLE ComHandle, BYTE _Sec, BYTE _KEYLen, BYTE _KEY[]);
int APIENTRY RF_WriteBlock(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE _BlockDataLen, BYTE _BlockData[]);

int APIENTRY RF_InitValue(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE * _DataLen, BYTE _Data[]);
int APIENTRY RF_ReadValue(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE * _DataLen, BYTE _Data[]);
int APIENTRY RF_Decrement(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE * _DataLen, BYTE _Data[]);
int APIENTRY RF_Increment(HANDLE ComHandle, BYTE _Sec, BYTE _Block, BYTE * _DataLen, BYTE _Data[]);

int APIENTRY IC24CXX_DetectCard(HANDLE ComHandle,BYTE *_CardType);
int APIENTRY IC24CXX_ReadBlock(HANDLE ComHandle, BYTE _CardType, int _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY IC24CXX_WriteBlock(HANDLE ComHandle, BYTE _CardType, int _Address, BYTE _dataLen, BYTE _BlockData[]);

int APIENTRY CPU_Reset(HANDLE ComHandle, BYTE *_CPUType,BYTE _exData[], int *_exdataLen);//�ɣ����ݾɰ�
int APIENTRY CPU_ColdReset(HANDLE ComHandle, BYTE _CPUMode, BYTE *_CPUType,BYTE _exData[], int *_exdataLen);//�£��滻CPU_Reset
int APIENTRY CPU_WarmReset(HANDLE ComHandle, BYTE *_CPUType,BYTE _exData[], int *_exdataLen);
int APIENTRY CPU_T0_C_APDU(HANDLE ComHandle, int _dataLen, BYTE _APDUData[], BYTE _exData[], int *_exdataLen);
int APIENTRY CPU_T1_C_APDU(HANDLE ComHandle, int _dataLen, BYTE _APDUData[], BYTE _exData[], int *_exdataLen);

int APIENTRY SIM_Reset(HANDLE ComHandle,BYTE _VOLTAGE,BYTE _SIMNo, BYTE *_SIMTYPE,BYTE _exData[], int *_exdataLen);
int APIENTRY SIM_T0_C_APDU(HANDLE ComHandle, BYTE SIMNo, int _dataLen, BYTE _APDUData[], BYTE _exData[], int *_exdataLen);
int APIENTRY SIM_T1_C_APDU(HANDLE ComHandle, BYTE SIMNo, int _dataLen, BYTE _APDUData[], BYTE _exData[], int *_exdataLen);
int APIENTRY SIM_CardClose(HANDLE ComHandle);

int APIENTRY SLE4442_Reset(HANDLE ComHandle);
int APIENTRY SLE4442_Read(HANDLE ComHandle, BYTE _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY SLE4442_ReadP(HANDLE ComHandle, BYTE _BlockDataLen, BYTE _BlockData[]);
int APIENTRY SLE4442_ReadS(HANDLE ComHandle, BYTE _BlockDataLen, BYTE _BlockData[]);
int APIENTRY SLE4442_VerifyPWD(HANDLE ComHandle, BYTE _PWDataLen, BYTE _PWData[]);
int APIENTRY SLE4442_Write(HANDLE ComHandle, BYTE _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY SLE4442_WriteP(HANDLE ComHandle, BYTE _BlockDataLen, BYTE _BlockData[]);
int APIENTRY SLE4442_WritePWD(HANDLE ComHandle, BYTE _PWDatalen, BYTE _PWData[]);

int APIENTRY SLE4428_Reset(HANDLE ComHandle);
int APIENTRY SLE4428_Read(HANDLE ComHandle, int _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY SLE4428_ReadP(HANDLE ComHandle, int _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY SLE4428_VerifyPWD(HANDLE ComHandle, BYTE _PWDataLen, BYTE _PWData[]);
int APIENTRY SLE4428_WritePWD(HANDLE ComHandle,BYTE _PWDataLen, BYTE _PWDataOld[],BYTE _PWDataNew[]);
int APIENTRY SLE4428_Write(HANDLE ComHandle, int _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY SLE4428_WriteP(HANDLE ComHandle, int _Address, BYTE _dataLen, BYTE _BlockData[]);

int APIENTRY AT88SC102_Reset(HANDLE ComHandle);
int APIENTRY AT88SC102_Security1Clear(HANDLE ComHandle, BYTE _Index, BYTE _Address, BYTE _dataLen);
int APIENTRY AT88SC102_Security2ClearApp1(HANDLE ComHandle,BYTE _Security2App1PWLen,BYTE _Security2App1PW[]);
int APIENTRY AT88SC102_Security2ClearApp2(HANDLE ComHandle,BYTE _EC2, BYTE _Security2App2PWLen, BYTE _Security2App2PW[]);
int APIENTRY AT88SC102_Read(HANDLE ComHandle, BYTE _Index, BYTE _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY AT88SC102_VerifyPWD(HANDLE ComHandle, BYTE _PWDataLen, BYTE _PWData[]);
int APIENTRY AT88SC102_Write(HANDLE ComHandle, BYTE _Index, BYTE _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY AT88SC102_WritePWD(HANDLE ComHandle, BYTE _PWIndex, BYTE _PWDataLen,BYTE _PWData[]);
int APIENTRY AT88SC102_InitSecurity2(HANDLE ComHandle, BYTE _CtrlMode);
int APIENTRY AT88SC102_DisableEC2(HANDLE ComHandle);

int APIENTRY AT88SC1604_Clear(HANDLE ComHandle, BYTE _Index, int _Address, BYTE _dataLen);
int APIENTRY AT88SC1604_Personalization(HANDLE ComHandle,BYTE _data);
int APIENTRY AT88SC1604_Read(HANDLE ComHandle, BYTE _Index, int _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY AT88SC1604_Reset(HANDLE ComHandle);
int APIENTRY AT88SC1604_VerifyPWD(HANDLE ComHandle, BYTE _PWIndex,BYTE _PWDataLen, BYTE _PWData[]);
int APIENTRY AT88SC1604_Write(HANDLE ComHandle, BYTE _Index, int _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY AT88SC1604_WritePWD(HANDLE ComHandle, BYTE _PWIndex,BYTE _PWDataLen,BYTE _PWData[]);

int APIENTRY AT88SC1608_Reset(HANDLE ComHandle);
int APIENTRY AT88SC1604_VerifyPWD(HANDLE ComHandle, BYTE _PWIndex,BYTE _PWDataLen, BYTE _PWData[]);
int APIENTRY AT88SC1608_Read(HANDLE ComHandle, BYTE _Index, BYTE _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY AT88SC1608_Write(HANDLE ComHandle, BYTE _Index, BYTE _Address, BYTE _dataLen, BYTE _BlockData[]);
int APIENTRY AT88SC1608_ReadFUSE(HANDLE ComHandle, BYTE * _PER, BYTE * _CMA, BYTE * _FAB);
int APIENTRY AT88SC1608_WriteFUSE(HANDLE ComHandle);
int APIENTRY AT88SC1608_InitAuth(HANDLE ComHandle, BYTE _QLen, BYTE _Q[]);
int APIENTRY AT88SC1608_VerifyAuth(HANDLE ComHandle, BYTE _QLen, BYTE _Q[]);

int APIENTRY AT45D041_Reset(HANDLE ComHandle);
int APIENTRY AT45D041_Read(HANDLE ComHandle, int  _Address, int *_BlockDataLen, BYTE _BlockData[]);
int APIENTRY AT45D041_Write(HANDLE ComHandle, int  _Address, int _BlockDataLen, BYTE _BlockData[]);


//=========================CRT-284 U ===================================================

HANDLE APIENTRY USBOpen();
int APIENTRY USBClose(HANDLE ComHandle);
int APIENTRY GetDeviceCapabilities(HANDLE ComHandle, int *_InputReportByteLength, int *_OutputReportByteLength);
int APIENTRY USB_ExeCommand(HANDLE ComHandle,BYTE TxCmCode,BYTE TxPmCode,int TxDataLen,BYTE TxData[],int *RxDataLen,BYTE RxData[]);
