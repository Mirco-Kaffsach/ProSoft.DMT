using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace ProSoft.DMT.Exceptions;

/// <summary>
/// Class EnvironmentVariableNotFoundException.
/// Implements the <see cref="System.Exception" />
/// </summary>
/// <seealso cref="System.Exception" />
[ExcludeFromCodeCoverage]
[Serializable]
public class EnvironmentVariableNotFoundException : Exception
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EnvironmentVariableNotFoundException"/> class.
	/// </summary>
	public EnvironmentVariableNotFoundException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EnvironmentVariableNotFoundException"/> class.
	/// </summary>
	/// <param name="message">The message that describes the error.</param>
	public EnvironmentVariableNotFoundException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EnvironmentVariableNotFoundException"/> class.
	/// </summary>
	/// <param name="message">The message.</param>
	/// <param name="inner">The inner.</param>
	public EnvironmentVariableNotFoundException(string message, Exception inner) : base(message, inner)
	{
	}
}
