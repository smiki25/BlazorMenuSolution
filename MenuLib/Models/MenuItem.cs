using System.Collections.Generic;

namespace MenuLib.Models
{
    public class MenuItem
    {
        public string Text { get; set; }
        public List<MenuItem> Children { get; set; } = new List<MenuItem>();
        public bool IsExpanded { get; set; }
        public bool IsSelected { get; set; }
        public int Level { get; set; }

        public bool HasChildren => Children != null && Children.Count > 0;

        public MenuItem(string text)
        {
            Text = text;
        }

        public MenuItem AddChild(string text)
        {
            var child = new MenuItem(text)
            {
                Level = this.Level + 1
            };
            Children.Add(child);
            return child;
        }

        public static List<MenuItem> CreateSampleMenu()
        {
            var menuItems = new List<MenuItem>();

            var item1 = new MenuItem("Item 1");
            var item1_1 = item1.AddChild("Item 1.1");
            var item1_2 = item1.AddChild("Item 1.2");
            item1_2.AddChild("Item 1.2.1");
            item1_2.AddChild("Item 1.2.2");

            var item2 = new MenuItem("Item 2");
            item2.AddChild("Item 2.1");

            var item3 = new MenuItem("Item 3");

            menuItems.Add(item1);
            menuItems.Add(item2);
            menuItems.Add(item3);

            return menuItems;
        }
    }
}