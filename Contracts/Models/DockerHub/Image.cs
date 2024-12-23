using System.Diagnostics.CodeAnalysis;

namespace ProSoft.DMT.Contracts.Models.DockerHub;

/// <summary>
/// Class Image. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Image : IDisposable
{
    /// <summary>
    /// Gets or sets the architecture.
    /// </summary>
    /// <value>The architecture.</value>
    public string architecture { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the features.
    /// </summary>
    /// <value>The features.</value>
    public string features { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the variant.
    /// </summary>
    /// <value>The variant.</value>
    public string variant { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the digest.
    /// </summary>
    /// <value>The digest.</value>
    public string digest { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the os.
    /// </summary>
    /// <value>The os.</value>
    public string os { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the os features.
    /// </summary>
    /// <value>The os features.</value>
    public string os_features { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the os version.
    /// </summary>
    /// <value>The os version.</value>
    public object? os_version { get; set; }
    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>The size.</value>
    public int size { get; set; }
    /// <summary>
    /// Gets or sets the status.
    /// </summary>
    /// <value>The status.</value>
    public string status { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the last pulled.
    /// </summary>
    /// <value>The last pulled.</value>
    public DateTime last_pulled { get; set; }
    /// <summary>
    /// Gets or sets the last pushed.
    /// </summary>
    /// <value>The last pushed.</value>
    public DateTime last_pushed { get; set; }

    #region IDisposable Interface Implementation

    /// <summary>
    /// The disposed
    /// </summary>
    private bool _disposed;

    /// <summary>
    /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases unmanaged and - optionally - managed resources.
    /// </summary>
    /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
    [ExcludeFromCodeCoverage]
    private void Dispose(bool disposing)
    {
        if (!_disposed && disposing)
        {
            // Disposing Logic
        }

        _disposed = true;
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="Image" /> class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    ~Image()
    {
        this.Dispose(false);
    }

    #endregion
}
