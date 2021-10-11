using Robust.Shared.Log;
using System.Collections.Generic;
using Robust.Shared.Utility;
using System.Diagnostics.CodeAnalysis;

namespace Content.Server.DeviceNetwork
{
    public class NetworkPayload : Dictionary<string, object>
    {
        /// <summary>
        /// Tries to get a value from the payload and checks if that value is of type  T.
        /// </summary>
        /// <typeparam name="T">The type that should be casted to</typeparam>
        /// <returns>Whether the value was present in the payload and of the required type</returns>
        public bool TryGetValue<T>(string key, [NotNullWhen(true)] out T? value)
        {
            if (this.TryCastValue(key, out T? result))
            {
                value = result;
                return true;
            }

            value = default;
            return false;
        }
    }

}
