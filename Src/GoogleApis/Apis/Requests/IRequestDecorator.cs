using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Net;

namespace Google.Apis.Requests
{
    /// <summary>
    /// Interface that modifies <see cref="HttpWebRequest"/> objects to build up a request.
    /// </summary>
    public interface IRequestDecorator
    {
        /// <summary>
        /// Decorate an <see cref="HttpWebRequest"/>.
        /// </summary>
        /// <param name="webRequest">The <see cref="HttpWebRequest"/> to be decorated.</param>
        void DecorateRequest(HttpWebRequest webRequest);
    }
}
