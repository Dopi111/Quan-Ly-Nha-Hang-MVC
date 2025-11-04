# 🤝 Contributing to COCÔTTE Restaurant Management System

Thank you for your interest in contributing to COCÔTTE! We welcome contributions from the community.

## 📋 Table of Contents

- [Code of Conduct](#code-of-conduct)
- [How Can I Contribute?](#how-can-i-contribute)
- [Development Setup](#development-setup)
- [Pull Request Process](#pull-request-process)
- [Coding Standards](#coding-standards)
- [Commit Messages](#commit-messages)
- [Testing Guidelines](#testing-guidelines)

---

## 📜 Code of Conduct

By participating in this project, you are expected to uphold our Code of Conduct:

- Be respectful and inclusive
- Accept constructive criticism gracefully
- Focus on what is best for the community
- Show empathy towards other community members

---

## 🎯 How Can I Contribute?

### 🐛 Reporting Bugs

Before creating bug reports, please check existing issues. When creating a bug report, include:

- **Clear title and description**
- **Steps to reproduce** the issue
- **Expected behavior** vs **actual behavior**
- **Screenshots** if applicable
- **Environment details** (OS, .NET version, browser)

**Example:**
```markdown
## Bug: Cart total calculation incorrect

**Steps to reproduce:**
1. Add 2 items to cart
2. View cart page
3. Total shows wrong amount

**Expected:** Total = 100,000 VNĐ
**Actual:** Total = 50,000 VNĐ

**Environment:** Windows 11, .NET 8.0, Chrome 120
```

### 💡 Suggesting Features

Feature suggestions are welcome! Please include:

- **Use case** - Why is this feature needed?
- **Proposed solution** - How should it work?
- **Alternatives** - Other approaches you've considered
- **Priority** - Low, Medium, High

### 🔧 Pull Requests

1. **Fork** the repository
2. **Create** a feature branch (`git checkout -b feature/AmazingFeature`)
3. **Make** your changes
4. **Test** thoroughly
5. **Commit** with meaningful messages
6. **Push** to your fork
7. **Open** a Pull Request

---

## 💻 Development Setup

### Prerequisites

```bash
# .NET SDK 8.0 or later
dotnet --version

# Git
git --version
```

### Clone & Setup

```bash
# Clone your fork
git clone https://github.com/YOUR_USERNAME/Quan-Ly-Nha-Hang-MVC.git
cd Quan-Ly-Nha-Hang-MVC

# Add upstream remote
git remote add upstream https://github.com/Dopi111/Quan-Ly-Nha-Hang-MVC.git

# Create feature branch
git checkout -b feature/my-new-feature

# Restore dependencies
dotnet restore

# Build project
dotnet build

# Run project
dotnet run
```

### Keeping Your Fork Updated

```bash
# Fetch upstream changes
git fetch upstream

# Merge upstream changes
git checkout main
git merge upstream/main

# Update your feature branch
git checkout feature/my-new-feature
git rebase main
```

---

## 🔄 Pull Request Process

### Before Submitting

- [ ] Code follows project coding standards
- [ ] All tests pass locally
- [ ] Added tests for new features
- [ ] Updated documentation if needed
- [ ] No console warnings or errors
- [ ] Tested on multiple browsers (Chrome, Firefox, Edge)
- [ ] Responsive design works on mobile

### PR Template

```markdown
## Description
Brief description of changes

## Type of Change
- [ ] Bug fix
- [ ] New feature
- [ ] Breaking change
- [ ] Documentation update

## Testing
How to test your changes

## Screenshots (if applicable)
Before/after screenshots

## Checklist
- [ ] Code follows style guidelines
- [ ] Self-review completed
- [ ] Comments added for complex code
- [ ] Documentation updated
- [ ] No new warnings
- [ ] Tests added/updated
- [ ] Tests pass locally
```

### Review Process

1. Maintainers will review your PR within **3-5 business days**
2. Address any requested changes
3. Once approved, your PR will be merged
4. Delete your feature branch after merge

---

## 📝 Coding Standards

### C# Style Guide

```csharp
// ✅ Good
public class MenuController : Controller
{
    private readonly ILogger<MenuController> _logger;

    public MenuController(ILogger<MenuController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var dishes = GetDishes();
        return View(dishes);
    }
}

// ❌ Bad
public class menucontroller : Controller
{
    public IActionResult index() {
        var dishes=GetDishes();
        return View(dishes);
    }
}
```

### Naming Conventions

- **Classes**: PascalCase (`MenuController`, `DishModel`)
- **Methods**: PascalCase (`GetDishes()`, `ProcessOrder()`)
- **Variables**: camelCase (`dishName`, `orderTotal`)
- **Constants**: UPPER_CASE (`MAX_ITEMS`, `DEFAULT_PAGE_SIZE`)
- **Private fields**: _camelCase (`_logger`, `_dbContext`)

### Code Organization

```csharp
// Order of class members:
// 1. Fields
// 2. Properties
// 3. Constructors
// 4. Public methods
// 5. Private methods

public class OrderService
{
    // 1. Fields
    private readonly IRepository _repository;

    // 2. Properties
    public int MaxItems { get; set; }

    // 3. Constructor
    public OrderService(IRepository repository)
    {
        _repository = repository;
    }

    // 4. Public methods
    public Order CreateOrder(List<Item> items)
    {
        // Implementation
    }

    // 5. Private methods
    private decimal CalculateTotal(List<Item> items)
    {
        // Implementation
    }
}
```

### Razor Views

```cshtml
@* ✅ Good *@
@model IEnumerable<Dish>

<div class="container">
    @foreach (var dish in Model)
    {
        <div class="card">
            <h3>@dish.Name</h3>
            <p>@dish.Price.ToString("#,##0") VNĐ</p>
        </div>
    }
</div>

@* ❌ Bad *@
@model IEnumerable<Dish>
<div class="container">
@foreach(var dish in Model){
<div class="card"><h3>@dish.Name</h3><p>@dish.Price</p></div>}
</div>
```

---

## 💬 Commit Messages

Follow [Conventional Commits](https://www.conventionalcommits.org/):

### Format

```
<type>(<scope>): <subject>

<body>

<footer>
```

### Types

- **feat**: New feature
- **fix**: Bug fix
- **docs**: Documentation changes
- **style**: Formatting, missing semicolons, etc.
- **refactor**: Code restructuring
- **test**: Adding tests
- **chore**: Maintenance tasks

### Examples

```bash
# Feature
git commit -m "feat(menu): add dish filtering by category"

# Bug fix
git commit -m "fix(cart): correct total calculation for discount items"

# Documentation
git commit -m "docs: update installation instructions in README"

# Refactor
git commit -m "refactor(controllers): simplify order processing logic"

# Multiple paragraphs
git commit -m "feat(reservation): add table booking system

- Add ReservationController
- Create booking form view
- Implement email confirmation
- Add admin approval workflow

Closes #123"
```

---

## 🧪 Testing Guidelines

### Unit Tests (Future)

```csharp
[Fact]
public void CalculateTotal_WithValidItems_ReturnsCorrectSum()
{
    // Arrange
    var items = new List<CartItem>
    {
        new() { Price = 100000, Quantity = 2 },
        new() { Price = 50000, Quantity = 1 }
    };
    var service = new OrderService();

    // Act
    var total = service.CalculateTotal(items);

    // Assert
    Assert.Equal(250000, total);
}
```

### Integration Tests (Future)

```csharp
[Fact]
public async Task CreateOrder_WithValidData_SavesToDatabase()
{
    // Arrange
    var options = new DbContextOptionsBuilder<AppDbContext>()
        .UseInMemoryDatabase(databaseName: "TestDb")
        .Options;

    using var context = new AppDbContext(options);
    var controller = new OrderController(context);
    var order = new Order { CustomerName = "Test" };

    // Act
    var result = await controller.Create(order);

    // Assert
    var savedOrder = await context.Orders.FirstOrDefaultAsync();
    Assert.NotNull(savedOrder);
    Assert.Equal("Test", savedOrder.CustomerName);
}
```

### Manual Testing

Before submitting PR, test:

- [ ] Desktop (Chrome, Firefox, Edge)
- [ ] Mobile (Chrome, Safari)
- [ ] Tablet (iPad)
- [ ] Different screen sizes (375px, 768px, 1920px)
- [ ] All form validations
- [ ] Navigation flows
- [ ] Error scenarios

---

## 🏗️ Project Structure

When adding new features, follow existing structure:

```
Controllers/          # Add new controllers here
Models/              # Add new models here
Views/               # Add new views here
  ├── ControllerName/
  │   ├── Action1.cshtml
  │   └── Action2.cshtml
  └── Shared/        # Shared components
wwwroot/
  ├── css/           # Custom CSS
  ├── js/            # Custom JavaScript
  └── images/        # Images
```

---

## 📚 Resources

- [ASP.NET Core Docs](https://docs.microsoft.com/en-us/aspnet/core/)
- [C# Coding Conventions](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions)
- [Conventional Commits](https://www.conventionalcommits.org/)
- [Git Best Practices](https://git-scm.com/book/en/v2)

---

## ❓ Questions?

- **GitHub Issues**: For bugs and feature requests
- **Email**: info@cocotte.vn
- **Discussions**: GitHub Discussions (coming soon)

---

## 🎉 Recognition

Contributors will be recognized in:
- README.md Contributors section
- Release notes
- Project website (future)

---

**Thank you for contributing to COCÔTTE! 🙏**

<div align="center">

Made with ❤️ by the COCÔTTE Team

</div>
