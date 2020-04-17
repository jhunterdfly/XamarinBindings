using System;
using ObjCRuntime;

namespace Twilio.Chat.Client
{
	[Native]
    public enum TCHClientConnectionState : long
	{
		Unknown,
		Disconnected,
		Connected,
		Connecting,
		Denied,
		Error,
		FatalError
	}

	[Native]
	public enum TCHClientSynchronizationStatus : long
	{
		Started = 0,
		ChannelsListCompleted,
		Completed,
		Failed
	}

	[Native]
	public enum TCHLogLevel : long
	{
		Silent = 0,
		Fatal,
		Critical,
		Warning,
		Info,
		Debug,
		Trace
	}

	[Native]
	public enum TCHChannelUpdate : long
	{
		Status = 1,
		LastConsumedMessageIndex,
		UniqueName,
		FriendlyName,
		Attributes,
		LastMessage,
		UserNotificationLevel
	}

	[Native]
	public enum TCHChannelSynchronizationStatus : long
	{
		None = 0,
		Identifier,
		Metadata,
		All,
		Failed
	}

	[Native]
	public enum TCHChannelStatus : long
	{
		Invited = 0,
		Joined,
		NotParticipating,
		Unknown
	}

	[Native]
	public enum TCHChannelType : long
	{
		ublic = 0,
		rivate
	}

	[Native]
	public enum TCHChannelNotificationLevel : long
	{
		Default = 0,
		Muted
	}

	[Native]
	public enum TCHChannelSortingCriteria : long
	{
		LastMessage = 0,
		FriendlyName,
		UniqueName
	}

	[Native]
	public enum TCHChannelSortingOrder : long
	{
		Ascending = 0,
		Descending
	}

	[Native]
	public enum TCHUserUpdate : long
	{
		FriendlyName = 0,
		Attributes,
		ReachabilityOnline,
		ReachabilityNotifiable
	}

	[Native]
	public enum TCHMemberUpdate : long
	{
		LastConsumedMessageIndex = 0,
		Attributes = 1
	}

	[Native]
	public enum TCHMemberType : long
	{
		Unset = 0,
		Other,
		Chat,
		Sms,
		Whatsapp
	}

	[Native]
	public enum TCHMessageUpdate : long
	{
		Body = 0,
		Attributes
	}

	[Native]
	public enum TCHMessageType : long
	{
		Text = 0,
		Media
	}
}
