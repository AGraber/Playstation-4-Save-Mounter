using System;
using System.Collections.Generic;
using System.Text;

namespace PS4Saves
{
    class offsets
    {
		//libSceUserService
        public const int sceUserServiceGetInitialUser = 0x00003390;
        public const int sceUserServiceGetLoginUserIdList = 0x00002B80;
        public const int sceUserServiceGetUserName = 0x000045B0;
		//libSceSaveData
        public const int sceSaveDataMount = 0x00029C70;
        public const int sceSaveDataUmount = 0x0002A490;
        public const int sceSaveDataDirNameSearch = 0x0002B270;
        public const int sceSaveDataInitialize3 = 0x00029AE0;
    }
}
