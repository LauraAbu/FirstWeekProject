using System.Data.Entity.ModelConfiguration;

namespace Contacts.Data.Repository
{
    public class MessageMappingConfiguration : EntityTypeConfiguration<Message>
    {
        public MessageMappingConfiguration()
        {

            this.ToTable("message");
            this.HasKey(t => t.Id);
            this.Property(t => t.ContactId).HasColumnName("contactId");
            this.Property(t => t.IsSent).HasColumnName("isSent");
            this.Property(t => t.Message1).HasColumnName("message");


        }


    }
}


