using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;
using Omu.ValueInjecter;
using Omu.ValueInjecter.Injections;


public class AvoidNullProps : LoopInjection
{
    protected override void SetValue(object source, object target, PropertyInfo sp, PropertyInfo tp)
    {
        if (sp.GetValue(source, null) == null) return;
        base.SetValue(source, target, sp, tp);
    }
}

