using System.ComponentModel.DataAnnotations;
using Volo.Abp.Content;

namespace RuiChen.Single.Books;
public class BookImportInput
{
    [Required]
    public IRemoteStreamContent Content { get; set; }   
}
