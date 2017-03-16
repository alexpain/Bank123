namespace Bank.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BankContext : DbContext
    {
        public BankContext()
            : base("name=Bank")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<AccessStatus> AccessStatus { get; set; }
        public virtual DbSet<AdminTable> AdminTable { get; set; }
        public virtual DbSet<CardInfo> CardInfo { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<ContractClient> ContractClient { get; set; }
        public virtual DbSet<Credit> Credit { get; set; }
        public virtual DbSet<CreditCard> CreditCard { get; set; }
        public virtual DbSet<CreditInfo> CreditInfo { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<CurrencyTransactions> CurrencyTransactions { get; set; }
        public virtual DbSet<Deposit> Deposit { get; set; }
        public virtual DbSet<DepositInfo> DepositInfo { get; set; }
        public virtual DbSet<ExchangeRates> ExchangeRates { get; set; }
        public virtual DbSet<Payments> Payments { get; set; }
        public virtual DbSet<PaymentsInfo> PaymentsInfo { get; set; }
        public virtual DbSet<Sale> Sale { get; set; }
        public virtual DbSet<StatusClient> StatusClient { get; set; }
        public virtual DbSet<StatusCreditCard> StatusCreditCard { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Transaction> Transaction { get; set; }
        public virtual DbSet<TypeServices> TypeServices { get; set; }
        public virtual DbSet<TypeTransaction> TypeTransaction { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessStatus>()
                .HasMany(e => e.AdminTable)
                .WithRequired(e => e.AccessStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AccessStatus>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.AccessStatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CardInfo>()
                .HasMany(e => e.CreditCard)
                .WithRequired(e => e.CardInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.ContractClient)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Credit)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Deposit)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Transaction)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ContractClient>()
                .HasMany(e => e.CreditCard)
                .WithRequired(e => e.ContractClient)
                .HasForeignKey(e => e.contractId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CreditInfo>()
                .HasMany(e => e.Credit)
                .WithRequired(e => e.CreditInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.CreditInfo)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.DepositInfo)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Currency>()
                .HasMany(e => e.ExchangeRates)
                .WithRequired(e => e.Currency)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CurrencyTransactions>()
                .HasMany(e => e.ExchangeRates)
                .WithRequired(e => e.CurrencyTransactions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepositInfo>()
                .HasMany(e => e.Deposit)
                .WithRequired(e => e.DepositInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PaymentsInfo>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.PaymentsInfo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusClient>()
                .HasMany(e => e.Client)
                .WithRequired(e => e.StatusClient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusClient>()
                .HasMany(e => e.Sale)
                .WithRequired(e => e.StatusClient)
                .HasForeignKey(e => e.statusId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusCreditCard>()
                .HasMany(e => e.CreditCard)
                .WithRequired(e => e.StatusCreditCard)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Credit)
                .WithRequired(e => e.Transaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Deposit)
                .WithRequired(e => e.Transaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaction>()
                .HasMany(e => e.Payments)
                .WithRequired(e => e.Transaction)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeServices>()
                .HasMany(e => e.Sale)
                .WithRequired(e => e.TypeServices)
                .HasForeignKey(e => e.servicesId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeServices>()
                .HasMany(e => e.Transaction)
                .WithRequired(e => e.TypeServices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeTransaction>()
                .HasMany(e => e.Transaction)
                .WithRequired(e => e.TypeTransaction)
                .WillCascadeOnDelete(false);
        }
    }
}
