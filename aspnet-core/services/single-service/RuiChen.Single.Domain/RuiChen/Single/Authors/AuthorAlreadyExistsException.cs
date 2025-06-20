using Volo.Abp;

namespace RuiChen.Single.Authors;
public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(SingleErrorCodes.Author.AuthorAlreadyExists)
    {
        WithData("Name", name);
    }
}
