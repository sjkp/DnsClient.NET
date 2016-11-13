/*
3.3.8. MR RDATA format (EXPERIMENTAL)

    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+
    /                   NEWNAME                     /
    /                                               /
    +--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+--+

where:

NEWNAME         A <domain-name> which specifies a mailbox which is the
                proper rename of the specified mailbox.

MR records cause no additional section processing.  The main use for MR
is as a forwarding entry for a user who has moved to a different
mailbox.
*/
namespace DnsClient.Protocol
{
    public class RecordMR : Record
    {
        public string NewName { get; }

        public RecordMR(ResourceRecord resource, RecordReader recordReader)
            : base(resource)
        {
            NewName = recordReader.ReadDomainName();
        }

        public override string ToString()
        {
            return NewName;
        }
    }
}