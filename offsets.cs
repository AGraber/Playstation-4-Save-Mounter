using System;
using System.Collections.Generic;
using System.Text;

namespace PS4Saves
{
    class offsets
    {
        //libSceUserService
        public const int sceUserServiceGetInitialUser = 0x000033C0;
        public const int sceUserServiceGetLoginUserIdList = 0x00002C00;
        public const int sceUserServiceGetUserName = 0x000045A0;
        //libSceSaveData
        public const int sceSaveDataMount = 0x00028130;
        public const int sceSaveDataUmount = 0x000288E0;
        public const int sceSaveDataDirNameSearch = 0x000296C0;
        public const int sceSaveDataInitialize3 = 0x00027FA0;
    }
}
