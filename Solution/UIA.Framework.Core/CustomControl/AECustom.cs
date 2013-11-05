﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Automation;

namespace UIA.Framework.Core.CustomControl
{
	public class AECustom : AEControlBase
    {
		public AECustom(AutomationElement ae)
            : base(ae)
        { }

        public void Set(string text)
        {
            var pattern = TryGetPattern(ValuePattern.Pattern);
			if (null != pattern)
				((ValuePattern)pattern).SetValue(text);
			else
				throw new NotSupportedException();
        }

        public string Value
        {
            get
            {
				var pattern = TryGetPattern(ValuePattern.Pattern);
				if (null != pattern)
					return ((ValuePattern)pattern).Current.Value;
				else
					throw new NotSupportedException();
            }
        }

	}
}
