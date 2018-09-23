using System;
using System.Collections.Generic;

namespace dotnetcoreapirest.Data.Converter
{
    public interface IParser<O, D>
    {
		D Parse(O Origem);
		List<D> ParseList(List<O> Origem);

    }
}
