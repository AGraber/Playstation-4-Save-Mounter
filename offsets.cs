using System;
using System.Collections.Generic;
using System.Text;

namespace PS4Saves
{
    class offsets
    {
		//libSceUserService
        public const int sceUserServiceGetInitialUser = 0x000033B0;
        public const int sceUserServiceGetLoginUserIdList = 0x00002BB0;
        public const int sceUserServiceGetUserName = 0x000045D0;
		//libSceSaveData
        public const int sceSaveDataMount = 0x00028440;
        public const int sceSaveDataUmount = 0x00028BF0;
        public const int sceSaveDataDirNameSearch = 0x000299D0;
        public const int sceSaveDataInitialize3 = 0x000282B0;
    }
}
