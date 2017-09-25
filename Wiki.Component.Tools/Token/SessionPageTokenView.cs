using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Wiki.Component.Tools.Token
{
    public class SessionPageTokenView : PageTokenViewBase
    {
        public string SessionMyToken { get; set; }

        public SessionPageTokenView(string sessionmytoken)
        {
            SessionMyToken = sessionmytoken;
        }

        #region PageTokenViewBase

        /// <inheritdoc />
        /// <summary>
        /// Generates the page token.
        /// </summary>
        /// <returns></returns>
        public override string GeneratePageToken()
        {
            if (HttpContext.Current.Session[SessionMyToken] != null)
            {
                return HttpContext.Current.Session[SessionMyToken].ToString();
            }
            else
            {
                var token = GenerateHashToken();
                HttpContext.Current.Session[SessionMyToken] = token;
                return token;
            }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets the get last page token from Form
        /// </summary>
        public override string GetLastPageToken
        {
            get { return HttpContext.Current.Request.Params[HiddenTokenName]; }
        }

        /// <inheritdoc />
        /// <summary>
        /// Gets a value indicating whether [tokens match].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [tokens match]; otherwise, <c>false</c>.
        /// </value>
        public override bool TokensMatch
        {
            get
            {
                string formToken = GetLastPageToken;
                if (formToken == null) return false;
                if (!formToken.Equals(GeneratePageToken())) return false;
                //Refresh token
                HttpContext.Current.Session[SessionMyToken] = GenerateHashToken();
                return true;
            }
        }

        #endregion

        #region Private Help Method

        /// <summary>
        /// Generates the hash token.
        /// </summary>
        /// <returns></returns>
        private string GenerateHashToken()
        {
            return Encrypt(
                HttpContext.Current.Session.SessionID + DateTime.Now.Ticks.ToString());
        }

        #endregion

        public static string Encrypt(string plaintext)
        {
            string cl1 = plaintext;
            string pwd = string.Empty;
            MD5 md5 = MD5.Create();
            byte[] s = md5.ComputeHash(Encoding.Unicode.GetBytes(cl1));
            for (int i = 0; i < s.Length; i++)
            {
                pwd = pwd + s[i].ToString("X");
            }
            return pwd;
        }
    }
}
