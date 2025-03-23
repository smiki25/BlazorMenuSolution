# Menu Component for Blazor

This is a customizable dropdown menu component for Blazor applications.

## Features

- Support for both top-level and nested menu items
- Unlimited nesting capability - menus can have any depth of parent/child items
- Smart positioning - first-level dropdowns appear below, nested ones to the right
- Auto-close when mouse leaves the menu area
- Clean, minimal styling that can be easily customized

## Implementation Details

### Component Structure

The component is split into two main parts:
- `Menu.razor` - Handles the top-level menu and first level of child items
- `MenuItemsRecursive.razor` - Enables unlimited nesting through recursion

### Design Decisions

1. **Hover-based interaction**: I implemented the menu to show/hide on mouse hover since it's the most intuitive approach and matches what users expect from dropdown menus.

2. **Recursive approach**: Rather than setting a fixed nesting level, I used recursion to allow unlimited nesting depth. This makes the component more flexible for different use cases.

3. **Menu management**: I added a MenuManager class to track active menus and prevent multiple menus from being open simultaneously. This creates a cleaner user experience.

4. **Item limit**: The dynamic demo is limited to 8 items maximum to ensure the UI remains usable without needing horizontal scrolling.

5. **Simple styling**: The CSS is deliberately minimal, making it easy to customize and integrate with existing design systems.

### Why This Approach?

I chose these implementation details to balance functionality, user experience, and code maintainability:

- The recursive pattern keeps the code DRY while supporting unlimited nesting
- Using standard mouse events (hover, leave) makes the menu feel natural to users
- The component structure follows Blazor best practices, with clean separation of concerns
- The styling is lightweight but provides all the visual cues users need

## Setup and Installation

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 or Visual Studio Code

### Getting Started

1. Clone the repository:
   ```
   git clone https://github.com/smiki25/BlazorMenuSolution.git
   cd BlazorMenuComponent
   ```

2. Open the solution in Visual Studio or VS Code:
   ```
   dotnet restore
   dotnet build
   ```

3. Run the sample application:
   ```
   cd SampleApp
   dotnet run
   ```

4. Navigate to the link provided in the build. 
For Example : Now listening on: http://localhost:5140

## Future Improvements

Potential enhancements that could be added:
- Keyboard navigation support
- Animation options for menu transitions