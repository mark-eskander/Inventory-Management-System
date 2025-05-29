using EF_Project.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Security.Cryptography.Xml;

namespace EF_Project.Context
{
    public class ConnectorDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = .\SQLSERVERD ; Initial catalog = Entity_F_Final_Project ; integrated Security = true ; Trust server certificate = true; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            # region InventoryItem
            // Define composite primary key for InventoryItem
            modelBuilder.Entity<InventoryItem>()
                .HasKey(i => new { i.InventoryId, i.ItemId });

            // Configure relationships (if missing)
            modelBuilder.Entity<InventoryItem>()
                .HasOne(ii => ii.Inventory)
                .WithMany(i=>i.Items)
                .HasForeignKey(ii => ii.InventoryId);

            modelBuilder.Entity<InventoryItem>()
                .HasOne(ii => ii.Item)
                .WithMany(i => i.Inventories)
                .HasForeignKey(ii => ii.ItemId);
            #endregion

            #region  PullOrederDetails
            modelBuilder.Entity<PullOrederDetails>()
                .HasKey(pod => new { pod.PullOrederId, pod.ItemId });

            // PullOrder relationship
            modelBuilder.Entity<PullOrederDetails>()
                .HasOne(pod => pod.PullOrder)
                .WithMany(po => po.PullOrderDetails)
                .HasForeignKey(pod => pod.PullOrederId)
                .OnDelete(DeleteBehavior.Cascade); // Keep cascade for this path

            // Item relationship
            modelBuilder.Entity<PullOrederDetails>()
                .HasOne(pod => pod.item)
                .WithMany(i => i.PullOrderDetails)
                .HasForeignKey(pod => pod.ItemId)
                .OnDelete(DeleteBehavior.NoAction); // Or .Cascade if needed

            // Supplier relationship (FIX HERE)
            modelBuilder.Entity<PullOrederDetails>()
                .HasOne(pod => pod.supplier)
                .WithMany(i => i.PullOrderDetails)
                .HasForeignKey(pod => pod.SupplierId)
                .OnDelete(DeleteBehavior.NoAction); // Disable cascade delete
            #endregion

            #region SupplyOrederDetails
            // compsite PK
            modelBuilder.Entity<SupplyOrederDetails>()
                .HasKey(s => new { s.SupplyOrderId, s.ItemId });

            // Relationships
            modelBuilder.Entity<SupplyOrederDetails>()
                .HasOne(pod => pod.SupplyOrder)   // SupplyOrder
                .WithMany(po => po.supplyOrederDetails)
                .HasForeignKey(pod => pod.SupplyOrderId)  // Fk From table
                .OnDelete(DeleteBehavior.Cascade)  // Keep cascade for this path
                .OnDelete(DeleteBehavior.NoAction); // Fix here

            modelBuilder.Entity<SupplyOrederDetails>()
                .HasOne(pod => pod.Item)  // item 
                .WithMany(po => po.SupplyOrederDetails)
                .HasForeignKey(pod => pod.ItemId) // Fk From table
                .OnDelete(DeleteBehavior.NoAction);
            #endregion




            #region inventory_Audit


            // Configure the "from" relationship
            modelBuilder.Entity<From_Inv_to_Inv_Tracker>()
                .HasOne(f => f.from_inv_nav)           // Navigation property in From_Inv_to_Inv_Tracker
                .WithMany(i => i.FromTransfers)        // Collection in Inventory
                .HasForeignKey(f => f.from);            // Foreign key in From_Inv_to_Inv_Tracker

            // Configure the "to" relationship
            modelBuilder.Entity<From_Inv_to_Inv_Tracker>()
                .HasOne(f => f.to_inv_nav)             // Navigation property in From_Inv_to_Inv_Tracker
                .WithMany(i => i.ToTransfers)          // Collection in Inventory
                .HasForeignKey(f => f.to);            // Foreign key in From_Inv_to_Inv_Tracker
            #endregion

        }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }
        public DbSet<Client> Clients { get; set; }

        // Add missing DbSets (based on project requirements)
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SupplyOrder> SupplyOrders { get; set; }
        public DbSet<SupplyOrederDetails> supplyOrederDetails { get; set; }
        public DbSet<PullOrederDetails> pullOrederDetails { get; set; }
        public DbSet<PullOrder> PullOrders { get; set; }

        public DbSet<Audit_Tracking> AuditTable { get; set; }
        public DbSet<From_Inv_to_Inv_Tracker> InvToInvAudit { get; set; }

    }
}
