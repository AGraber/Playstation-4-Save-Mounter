using System;
using System.Collections.Generic;
using System.Text;

namespace PS4Saves
{
    class offsets
    {
		//libSceUserService
        public const int sceUserServiceGetInitialUser = 0x00003430;
        public const int sceUserServiceGetLoginUserIdList = 0x00002BE0;
        public const int sceUserServiceGetUserName = 0x00004560;
		//libSceSaveData
        public const int sceSaveDataMount = 0x0002B2D0;
        public const int sceSaveDataUmount = 0x0002BA80;
        public const int sceSaveDataDirNameSearch = 0x0002C870;
        public const int sceSaveDataInitialize3 = 0x00002B140;
    }
}
