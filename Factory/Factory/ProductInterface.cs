using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    public interface ProductInterface
    {
        string marcbuild();
    }
    public interface ProductModelInterface
    {
        string modelbuild();
    }

    public interface ProductCompInterface
    {
        string complbuild();
    }

}
