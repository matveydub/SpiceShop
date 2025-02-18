﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dubasov_TeaCompany.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities1 : DbContext
    {
        public Entities1()
            : base("name=Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Delivery> Delivery { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Supply> Supply { get; set; }
        public virtual DbSet<SupplyProduct> SupplyProduct { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<ClientStatistics> ClientStatistics { get; set; }
        public virtual DbSet<ProductPerformance> ProductPerformance { get; set; }
        public virtual DbSet<SalesSummary> SalesSummary { get; set; }
        public virtual DbSet<TeaInventory> TeaInventory { get; set; }
        public virtual DbSet<TopProduct> TopProduct { get; set; }
    
        [DbFunction("Entities1", "CategoryInfo")]
        public virtual IQueryable<CategoryInfo_Result> CategoryInfo(Nullable<int> categoryID)
        {
            var categoryIDParameter = categoryID.HasValue ?
                new ObjectParameter("categoryID", categoryID) :
                new ObjectParameter("categoryID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CategoryInfo_Result>("[Entities1].[CategoryInfo](@categoryID)", categoryIDParameter);
        }
    
        [DbFunction("Entities1", "ClientOrders")]
        public virtual IQueryable<ClientOrders_Result> ClientOrders(Nullable<int> clientID)
        {
            var clientIDParameter = clientID.HasValue ?
                new ObjectParameter("ClientID", clientID) :
                new ObjectParameter("ClientID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ClientOrders_Result>("[Entities1].[ClientOrders](@ClientID)", clientIDParameter);
        }
    
        [DbFunction("Entities1", "CourierInfo")]
        public virtual IQueryable<CourierInfo_Result> CourierInfo(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("employeeID", employeeID) :
                new ObjectParameter("employeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<CourierInfo_Result>("[Entities1].[CourierInfo](@employeeID)", employeeIDParameter);
        }
    
        [DbFunction("Entities1", "DeliveryCount")]
        public virtual IQueryable<DeliveryCount_Result> DeliveryCount(Nullable<int> employeeID)
        {
            var employeeIDParameter = employeeID.HasValue ?
                new ObjectParameter("EmployeeID", employeeID) :
                new ObjectParameter("EmployeeID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<DeliveryCount_Result>("[Entities1].[DeliveryCount](@EmployeeID)", employeeIDParameter);
        }
    
        [DbFunction("Entities1", "GetAge")]
        public virtual IQueryable<GetAge_Result> GetAge(Nullable<System.DateTime> birthday)
        {
            var birthdayParameter = birthday.HasValue ?
                new ObjectParameter("birthday", birthday) :
                new ObjectParameter("birthday", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<GetAge_Result>("[Entities1].[GetAge](@birthday)", birthdayParameter);
        }
    
        [DbFunction("Entities1", "ProductSales")]
        public virtual IQueryable<ProductSales_Result> ProductSales(Nullable<int> productID)
        {
            var productIDParameter = productID.HasValue ?
                new ObjectParameter("ProductID", productID) :
                new ObjectParameter("ProductID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<ProductSales_Result>("[Entities1].[ProductSales](@ProductID)", productIDParameter);
        }
    
        public virtual ObjectResult<EmployeeStatistics_Result> EmployeeStatistics()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<EmployeeStatistics_Result>("EmployeeStatistics");
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<Nullable<decimal>> TotalSumMonth()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("TotalSumMonth");
        }
    
        public virtual int UpdateAllOrderTotalPrices()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateAllOrderTotalPrices");
        }
    }
}
