using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transformer.NET
{
    public class TokenNotUniqueException : Exception
    {
        private Token token;
        public TokenNotUniqueException(Token token)
        {
            this.token = token;
        }

        public override string Message
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Token is not unique");
                sb.AppendLine("-------------------");
                sb.AppendFormat("ID = {0}", token.ID);
                sb.AppendLine();
                sb.AppendFormat("TagName = {0}", token.TagName);
                sb.AppendLine();
                sb.AppendFormat("Match = {0}", token.Match.ToString());
                sb.AppendLine();
                return sb.ToString();
            }
        }
    }
}
