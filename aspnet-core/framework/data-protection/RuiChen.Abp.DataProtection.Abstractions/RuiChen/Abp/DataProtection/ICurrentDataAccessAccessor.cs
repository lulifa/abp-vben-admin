namespace RuiChen.Abp.DataProtection;

public interface ICurrentDataAccessAccessor
{
    DataAccessOperation[] Current { get; set; }
}
