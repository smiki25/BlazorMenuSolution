using System;
using System.Collections.Generic;

namespace MenuLib.Models
{
    public class MenuManager
    {
        private HashSet<string> _activeMenus = new HashSet<string>();

        public event Action? MenuStateChanged;

        public void CloseAllExcept(string menuId)
        {
            _activeMenus.Clear();
            _activeMenus.Add(menuId);
            MenuStateChanged?.Invoke();
        }

        public bool IsMenuActive(string menuId)
        {
            return _activeMenus.Contains(menuId);
        }

        public void SetMenuActive(string menuId, bool isActive)
        {
            if (isActive)
            {
                _activeMenus.Add(menuId);
            }
            else
            {
                _activeMenus.Remove(menuId);
            }
            MenuStateChanged?.Invoke();
        }
    }
}