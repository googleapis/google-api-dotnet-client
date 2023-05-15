namespace Google.Apis.Http
{
    /// <summary>
    /// A delegate used to intercept stream data without modifying it.
    /// The parameters should always be validated before the delegate is called,
    /// so the delegate itself does not need to validate them again.
    /// </summary>
    /// <param name="buffer">The buffer containing the data.</param>
    /// <param name="offset">The offset into the buffer.</param>
    /// <param name="count">The number of bytes being read/written.</param>
    public delegate void StreamInterceptor(byte[] buffer, int offset, int count);
}
