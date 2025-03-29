using DrugStoreApplication.Database.ssms;
using DrugStoreApplication.Database.ssms.models;
using Microsoft.EntityFrameworkCore;
using Type = DrugStoreApplication.Database.ssms.models.Type;

namespace DrugStoreApplication;

public class Service
{
    public Service()
    {
        
    }
    
    private readonly AlphaStoreContext _context = new AlphaStoreContext();

    public int AddUser(string Login, string Password, string Phone, int RoleId)
    {
        _context.Database.ExecuteSqlRaw("SET IDENTITY_INSERT Users ON");
        var user = new User
        {
            Login = Login,
            Password = Password,
            Phone = Phone,
            RoleId = RoleId,
        };

        if (_context.Users.Any(u => u.Login == user.Login && u.Phone == user.Phone)) return -1;
        try
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return -1;
            
        }
    }

    public int DeleteUser(int UserId)
    {
        var user = _context.Users.Find(UserId);

        try
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
            return user.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int EditUser(int id, string Login, string Password, string Phone)
    {
        var user = _context.Users.Find(id);
        
        user.Login = Login;
        user.Password = Password;
        user.Phone = Phone;

        try
        {
            _context.Users.Update(user);
            _context.SaveChanges();
            return user.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int AddProduct(string Name, int Price, int Quantity, string ImagePath, int TypeId, int SupplierId)
    {
        var product = new Product
        {
            Name = Name,
            Price = Price,
            Quantity = Quantity,
            ImagePath = ImagePath,
            SupplierId = SupplierId,
            TypeId = TypeId
        };

        if (_context.Products.Any(p => p.Name == product.Name && p.ImagePath == product.ImagePath)) return -1;
        try
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int DeleteProduct(int ProductId)
    {
        var product = _context.Products.Find(ProductId);

        try
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
            return product.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int EditProduct(int id, string Name, int Price, int Quantity, string ImagePath, int TypeId,
        int SupplierId)
    {
        var product = _context.Products.Find(id);
        
        product.Name = Name;
        product.Price = Price;
        product.Quantity = Quantity;
        product.ImagePath = ImagePath;
        product.SupplierId = SupplierId;
        product.TypeId = TypeId;
        
            try
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return product.Id;
            }
            catch
            {
                return -1;
            }
    }

    public int AddSupplier(string Name, string Phone)
    {
        var supplier = new Supplier
        {
            Name = Name,
            Phone = Phone
        };

        if (_context.Suppliers.Any(p => p.Name == supplier.Name && p.Phone == supplier.Phone)) return -1;
        try
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
            return supplier.Id;
        }
        catch 
        {
            return -1;
        }
    }

    public int DeleteSupplier(int Id)
    {
        var supplier = _context.Suppliers.Find(Id);

        try
        {
            _context.Suppliers.Remove(supplier);
            _context.SaveChanges();
            return supplier.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int EditSupplier(int id, String Name, string Phone)
    {
        var supplier = _context.Suppliers.Find(id);
        
        supplier.Name = Name;
        supplier.Phone = Phone;

        if (_context.Suppliers.Any(p => p.Name == supplier.Name && p.Phone == supplier.Phone)) return -1;
        try
        {
            _context.Suppliers.Update(supplier);
            _context.SaveChanges();
            return supplier.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int AddSale(DateTime Date, int Quantity, int Price, int MedicineId, int UserId)
    {
        var sale = new Sale
        {
            Date = Date,
            Quantity = Quantity,
            Price = Price,
            MedicineId = MedicineId,
            UserId = UserId
        };

        if (sale.Date > DateTime.Now && sale.Date < DateTime.Now &&
            sale is { Medicine: null, User: null, UserId: 1 } &&
            sale.Medicine.Quantity - sale.Quantity < 0) return -1;
        try
        {
            _context.Sales.Add(sale);
            sale.Medicine.Quantity -= sale.Quantity;
            _context.SaveChanges();
            return sale.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int DeleteSale(int Id)
    {
        var sale = _context.Sales.Find(Id);
        try
        {
            _context.Sales.Remove(sale);
            _context.SaveChanges();
            return sale.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int AddOrder(DateTime date, int cost, int userId, int supplierId)
    {
        var order = new Order
        {
            Date = date,
            Cost = cost,
            UserId = userId,
            SupplierId = supplierId,
            StatusId = 1
        };

        try
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
            return order.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int DeleteOrder(int id)
    {
        var order = _context.Orders.Find(id);
        if (order == null) return -1;

        try
        {
            _context.Orders.Remove(order);
            _context.SaveChanges();
            return order.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int EditOrder(int id, int cost, int userId, int supplierId)
    {
        var order = _context.Orders.Find(id);
        if (order == null) return -1;

        order.Cost = cost;
        order.UserId = userId;
        order.SupplierId = supplierId;

        try
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
            return order.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int AddProductToOrder(int orderId, int productId, int quantity)
    {
        var product = _context.Products.Find(productId);
        if (product == null) return -1;

        var productsOrder = new ProductsOrder
        {
            OrderId = orderId,
            ProductId = productId,
            Quantity = quantity
        };

        try
        {
            _context.ProductsOrders.Add(productsOrder);
            product.Quantity += quantity;
            _context.SaveChanges();
            return productsOrder.Id;
        }
        catch
        {
            return -1;
        }
    }

    public int DeleteProductsFromOrder(Order order)
    {
        try
        {
            var productsInOrder = _context.ProductsOrders
                .Where(pio => pio.OrderId == order.Id)
                .ToList();
                    
            _context.ProductsOrders.RemoveRange(productsInOrder);
            _context.SaveChanges();
        }
        catch 
        {
            return -1;
        }
        
        return order.Id;
    }

    public int UpdateProductInOrder(int orderId, int newProductId, int newQuantity)
    {
        var productsOrder = _context.ProductsOrders.FirstOrDefault(po => po.OrderId == orderId);
        if (productsOrder == null) return -1;

        var currentProduct = _context.Products.Find(productsOrder.ProductId);
        var newProduct = _context.Products.Find(newProductId);
        
        if (currentProduct == null || newProduct == null) return -1;

        try
        {
            currentProduct.Quantity -= productsOrder.Quantity;

            productsOrder.ProductId = newProductId;
            productsOrder.Quantity = newQuantity;

            newProduct.Quantity += newQuantity;

            _context.ProductsOrders.Update(productsOrder);
            _context.SaveChanges();
            return productsOrder.Id;
        }
        catch
        {
            return -1;
        }
    }


    public int Login(string Login, string Password)
    {
        var user = _context.Users.FirstOrDefault(u => u.Login == Login);
        
        if (user == null)
        {
            return -1;
        }
        
        if (user.Password != Password)
        {
            return -2;
        }
        return user.Id;
    }

    public User GetUserById(int Id)
    {
        return _context.Users.Find(Id);
    }

    public Role GetRoleById(int id)
    {
        return _context.Roles.Find(id);
    }

    public List<User> GetUsers()
    {
        return _context.Users.Include("Role").ToList();
    }

    public List<Product> GetProducts()
    {
        return _context.Products.Include("Type").Include("Supplier").ToList();
    }

    public List<Order> GetOrders()
    {
        return _context.Orders.Include("Status").Include("Supplier").ToList();
    }

    public List<Sale> GetSales()
    {
        return _context.Sales.Include("User").Include(s => s.Medicine).ToList();
    }

    public List<Supplier> GetSuppliers()
    {
        return _context.Suppliers.ToList();
    }

    public List<Role> GetRoles()
    {
        return _context.Roles.ToList();
    }

    public List<Type> GetTypes()
    {
        return _context.Types.ToList();
    }

    public List<Status> GetStatuses()
    {
        return _context.Statuses.ToList();
    }

    public List<ProductsOrder> GetProductsFromOrder(int orderId)
    {
        return _context.ProductsOrders
            .Include(pio => pio.Product)
            .ThenInclude(p => p.Supplier)
            .Where(pio => pio.OrderId == orderId)
            .ToList();
    }
}