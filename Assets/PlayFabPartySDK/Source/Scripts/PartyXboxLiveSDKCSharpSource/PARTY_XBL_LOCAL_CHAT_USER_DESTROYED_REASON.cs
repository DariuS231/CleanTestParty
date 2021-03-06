using System;

namespace PartyXBLCSharpSDK
{
    //typedef enum PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON
    //{
    //    PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_UNAUTHORIZED_LOCAL_CHAT_USER,
    //    PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_FAILED_TO_GET_TOKEN_AND_SIGNATURE_FOR_LOCAL_CHAT_USER,
    //    PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_XBOX_LIVE_SERVICE_TEMPORARILY_UNAVAILABLE,
    //    PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_INTERNET_CONNECTIVITY_ERROR,
    //    PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_XBOX_LIVE_USER_NOT_SIGNED_IN,
    //    PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_UNKNOWN_ERROR,
    //}
    //PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON;
    public enum PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON : UInt32
    {
        PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_UNAUTHORIZED_LOCAL_CHAT_USER,
        PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_FAILED_TO_GET_TOKEN_AND_SIGNATURE_FOR_LOCAL_CHAT_USER,
        PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_XBOX_LIVE_SERVICE_TEMPORARILY_UNAVAILABLE,
        PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_INTERNET_CONNECTIVITY_ERROR,
        PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_XBOX_LIVE_USER_NOT_SIGNED_IN,
        PARTY_XBL_LOCAL_CHAT_USER_DESTROYED_REASON_UNKNOWN_ERROR,
    }
}