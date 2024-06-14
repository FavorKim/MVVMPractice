


namespace ViewModel.Extensions
{
    public static class TopLeftViewModelExtension
    {
        public static void RefreshViewModel(this TopLeftUIViewModel vm)
        {
            int tempId = 2;
            GameLogicManager.Inst.RefreshCharacterInfo(tempId, vm.OnRefreshViewModel);
        }

        public static void OnRefreshViewModel(this TopLeftUIViewModel vm, int userId, string name, int level)
        {
            vm.UserId = userId;
            vm.Name = name;
            vm.Level = level;
        }

        //public static void BindRegisterEvents(this TopLeftUIViewModel vm, bool isRegistering)
        //{

        //}

        public static void RegisterEventOnEnable(this TopLeftUIViewModel vm)
        {
            GameLogicManager.Inst.RegisterLevelUpCallback(vm.OnResponseLevelUp);
        }

        public static void UnRegisterEventOnDisable(this TopLeftUIViewModel vm)
        {
            GameLogicManager.Inst.UnRegisterLevelUpCallback(vm.OnResponseLevelUp);
        }

        public static void OnResponseLevelUp(this TopLeftUIViewModel vm, int userId, int level)
        {
            if (vm.UserId == userId)
            {
                vm.Level = level;
            }
        }
    }
}