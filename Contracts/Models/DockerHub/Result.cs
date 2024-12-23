using System.Diagnostics.CodeAnalysis;

namespace ProSoft.DMT.Contracts.Models.DockerHub;

/// <summary>
/// Class Result. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Result : IDisposable
{
    /// <summary>
    /// Gets or sets the creator.
    /// </summary>
    /// <value>The creator.</value>
    public int creator { get; set; }
    /// <summary>
    /// Gets or sets the identifier.
    /// </summary>
    /// <value>The identifier.</value>
    public int id { get; set; }
    /// <summary>
    /// Gets or sets the images.
    /// </summary>
    /// <value>The images.</value>
    public Image[] images { get; set; } = [];
    /// <summary>
    /// Gets or sets the last updated.
    /// </summary>
    /// <value>The last updated.</value>
    public DateTime last_updated { get; set; }
    /// <summary>
    /// Gets or sets the last updater.
    /// </summary>
    /// <value>The last updater.</value>
    public int last_updater { get; set; }
    /// <summary>
    /// Gets or sets the last updater username.
    /// </summary>
    /// <value>The last updater username.</value>
    public string last_updater_username { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string name { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the repository.
    /// </summary>
    /// <value>The repository.</value>
    public int repository { get; set; }
    /// <summary>
    /// Gets or sets the full size.
    /// </summary>
    /// <value>The full size.</value>
    public int full_size { get; set; }
    /// <summary>
    /// Gets or sets a value indicating whether this <see cref="Result"/> is v2.
    /// </summary>
    /// <value><c>true</c> if v2; otherwise, <c>false</c>.</value>
    public bool v2 { get; set; }
    /// <summary>
    /// Gets or sets the tag status.
    /// </summary>
    /// <value>The tag status.</value>
    public string tag_status { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the tag last pulled.
    /// </summary>
    /// <value>The tag last pulled.</value>
    public DateTime tag_last_pulled { get; set; }
    /// <summary>
    /// Gets or sets the tag last pushed.
    /// </summary>
    /// <value>The tag last pushed.</value>
    public DateTime tag_last_pushed { get; set; }

    /// <summary>
    /// Gets or sets the type of the media.
    /// </summary>
    /// <value>The type of the media.</value>
    public string media_type { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the type of the content.
    /// </summary>
    /// <value>The type of the content.</value>
    public string content_type { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the digest.
    /// </summary>
    /// <value>The digest.</value>
    public string digest { get; set; } = string.Empty;

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
    /// Finalizes an instance of the <see cref="Result" /> class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    ~Result()
    {
        this.Dispose(false);
    }

    #endregion
}
