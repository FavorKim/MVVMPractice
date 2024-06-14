
namespace TempProfile.Extension
{
    public static class TempProfileUIExtension
    {
        public static void RefreshTempProfileUI(this TempProfileUIViewModel vm)
        {
            int tempId = 2;
            GameLogicManager.Inst.RefreshCharacterInfo(tempId, vm.OnRefreshTempProfileUI);
        }

        public static void OnRefreshTempProfileUI(this TempProfileUIViewModel vm, int userId, string name, int level)
        {
            vm.UserId = userId;
            vm.PlayerName = name;
        }

        public static void RegisterOnEnable(this TempProfileUIViewModel vm)
        {
            GameLogicManager.Inst.RegisterChangeNameCallback(vm.ResponseChangeName);
        }

        public static void UnregisterOnDisable(this TempProfileUIViewModel vm)
        {
            GameLogicManager.Inst.UnRegisterChangeNameCallback(vm.ResponseChangeName);
        }

        public static void ResponseChangeName(this TempProfileUIViewModel vm, int userId, string playerName)
        {
            if (vm.UserId == userId)
            {
                vm.PlayerName = playerName;
            }
        }
    }
}