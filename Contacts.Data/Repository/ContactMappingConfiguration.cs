using System.Data.Entity.ModelConfiguration;

namespace Contacts.Data
{
    internal class ContactMappingConfiguration : EntityTypeConfiguration<Contact>
    {
        public ContactMappingConfiguration()
        {

            this.ToTable("contact");
            this.HasKey(t=>t.Id);
            this.Property(t => t.Name).HasColumnName("name");
            this.Property(t => t.LastName).HasColumnName("lastname");
            this.Property(t => t.EmailAddress).HasColumnName("email");
            this.Property(t => t.Phone).HasColumnName("phone");

        }
    }
}