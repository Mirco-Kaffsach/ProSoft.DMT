using System.Diagnostics.CodeAnalysis;

namespace ProSoft.DMT.Contracts.Models.DockerHub;

/// <summary>
/// Class Rootobject. This class cannot be inherited.
/// Implements the <see cref="System.IDisposable" />
/// </summary>
/// <seealso cref="System.IDisposable" />
public sealed class Rootobject : IDisposable
{
    /// <summary>
    /// Gets or sets the count.
    /// </summary>
    /// <value>The count.</value>
    public int count { get; set; }
    /// <summary>
    /// Gets or sets the next.
    /// </summary>
    /// <value>The next.</value>
    public string next { get; set; } = string.Empty;
    /// <summary>
    /// Gets or sets the previous.
    /// </summary>
    /// <value>The previous.</value>
    public object? previous { get; set; }

    /// <summary>
    /// Gets or sets the results.
    /// </summary>
    /// <value>The results.</value>
    public Result[] results { get; set; } = [];

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
    /// Finalizes an instance of the <see cref="Rootobject" /> class.
    /// </summary>
    [ExcludeFromCodeCoverage]
    ~Rootobject()
    {
        this.Dispose(false);
    }

    #endregion
}
