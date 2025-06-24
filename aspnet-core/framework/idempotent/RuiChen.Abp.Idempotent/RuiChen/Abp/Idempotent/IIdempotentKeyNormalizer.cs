using Volo.Abp.DynamicProxy;

namespace RuiChen.Abp.Idempotent;

public interface IIdempotentKeyNormalizer
{
    string NormalizeKey(IdempotentKeyNormalizerContext context);
}
