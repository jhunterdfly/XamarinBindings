using System;
using Foundation;
using ObjCRuntime;

namespace Twilio.Chat.Client
{
	// @interface TCHError : NSError
	[BaseType (typeof(NSError))]
	interface TCHError
	{
	}

	// @interface TCHResult : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHResult
	{
		// @property (readonly, nonatomic, strong) TCHError * _Nullable error;
		[NullAllowed, Export ("error", ArgumentSemantic.Strong)]
		TCHError Error { get; }

		// @property (readonly, assign, nonatomic) NSInteger resultCode;
		[Export ("resultCode")]
		nint ResultCode { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable resultText;
		[NullAllowed, Export ("resultText")]
		string ResultText { get; }

		// -(BOOL)isSuccessful;
		[Export ("isSuccessful")]
		bool IsSuccessful { get; }
	}

	// typedef void (^TCHCompletion)(TCHResult * _Nonnull);
	delegate void TCHCompletion (TCHResult arg0);

	// typedef void (^TCHTwilioClientCompletion)(TCHResult * _Nonnull, TwilioChatClient * _Nullable);
	delegate void TCHTwilioClientCompletion (TCHResult arg0, [NullAllowed] TwilioChatClient arg1);

	// typedef void (^TCHChannelDescriptorPaginatorCompletion)(TCHResult * _Nonnull, TCHChannelDescriptorPaginator * _Nullable);
	delegate void TCHChannelDescriptorPaginatorCompletion (TCHResult arg0, [NullAllowed] TCHChannelDescriptorPaginator arg1);

	// typedef void (^TCHMemberPaginatorCompletion)(TCHResult * _Nonnull, TCHMemberPaginator * _Nullable);
	delegate void TCHMemberPaginatorCompletion (TCHResult arg0, [NullAllowed] TCHMemberPaginator arg1);

	// typedef void (^TCHChannelCompletion)(TCHResult * _Nonnull, TCHChannel * _Nullable);
	delegate void TCHChannelCompletion (TCHResult arg0, [NullAllowed] TCHChannel arg1);

	// typedef void (^TCHMessageCompletion)(TCHResult * _Nonnull, TCHMessage * _Nullable);
	delegate void TCHMessageCompletion (TCHResult arg0, [NullAllowed] TCHMessage arg1);

	// typedef void (^TCHMessagesCompletion)(TCHResult * _Nonnull, NSArray<TCHMessage *> * _Nullable);
	delegate void TCHMessagesCompletion (TCHResult arg0, [NullAllowed] TCHMessage[] arg1);

	// typedef void (^TCHUserCompletion)(TCHResult * _Nonnull, TCHUser * _Nullable);
	delegate void TCHUserCompletion (TCHResult arg0, [NullAllowed] TCHUser arg1);

	// typedef void (^TCHUserDescriptorCompletion)(TCHResult * _Nonnull, TCHUserDescriptor * _Nullable);
	delegate void TCHUserDescriptorCompletion (TCHResult arg0, [NullAllowed] TCHUserDescriptor arg1);

	// typedef void (^TCHUserDescriptorPaginatorCompletion)(TCHResult * _Nonnull, TCHUserDescriptorPaginator * _Nullable);
	delegate void TCHUserDescriptorPaginatorCompletion (TCHResult arg0, [NullAllowed] TCHUserDescriptorPaginator arg1);

	// typedef void (^TCHCountCompletion)(TCHResult * _Nonnull, NSUInteger);
	delegate void TCHCountCompletion (TCHResult arg0, nuint arg1);

	// typedef void (^TCHMediaOnStarted)();
	delegate void TCHMediaOnStarted ();

	// typedef void (^TCHMediaOnProgress)(NSUInteger);
	delegate void TCHMediaOnProgress (nuint arg0);

	// typedef void (^TCHMediaOnCompleted)(NSString * _Nonnull);
	delegate void TCHMediaOnCompleted (string arg0);

	[Static]
	partial interface Constants
	{
		// extern NSString *const _Nonnull TCHChannelOptionFriendlyName;
		[Field ("TCHChannelOptionFriendlyName", "__Internal")]
		NSString TCHChannelOptionFriendlyName { get; }

		// extern NSString *const _Nonnull TCHChannelOptionUniqueName;
		[Field ("TCHChannelOptionUniqueName", "__Internal")]
		NSString TCHChannelOptionUniqueName { get; }

		// extern NSString *const _Nonnull TCHChannelOptionType;
		[Field ("TCHChannelOptionType", "__Internal")]
		NSString TCHChannelOptionType { get; }

		// extern NSString *const _Nonnull TCHChannelOptionAttributes;
		[Field ("TCHChannelOptionAttributes", "__Internal")]
		NSString TCHChannelOptionAttributes { get; }

		// extern NSString *const _Nonnull TCHErrorDomain;
		[Field ("TCHErrorDomain", "__Internal")]
		NSString TCHErrorDomain { get; }

		// extern const NSInteger TCHErrorGeneric;
		[Field ("TCHErrorGeneric", "__Internal")]
		nint TCHErrorGeneric { get; }

		// extern NSString *const _Nonnull TCHErrorMsgKey;
		[Field ("TCHErrorMsgKey", "__Internal")]
		NSString TCHErrorMsgKey { get; }
	}

	// @interface TCHChannels : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHChannels
	{
		// -(NSArray<TCHChannel *> * _Nonnull)subscribedChannels;
		[Export ("subscribedChannels")]
		TCHChannel[] SubscribedChannels { get; }

		// -(NSArray<TCHChannel *> * _Nonnull)subscribedChannelsSortedBy:(TCHChannelSortingCriteria)criteria order:(TCHChannelSortingOrder)order;
		[Export ("subscribedChannelsSortedBy:order:")]
		TCHChannel[] SubscribedChannelsSortedBy (TCHChannelSortingCriteria criteria, TCHChannelSortingOrder order);

		// -(void)userChannelDescriptorsWithCompletion:(TCHChannelDescriptorPaginatorCompletion _Nonnull)completion;
		[Export ("userChannelDescriptorsWithCompletion:")]
		void UserChannelDescriptorsWithCompletion (TCHChannelDescriptorPaginatorCompletion completion);

		// -(void)publicChannelDescriptorsWithCompletion:(TCHChannelDescriptorPaginatorCompletion _Nonnull)completion;
		[Export ("publicChannelDescriptorsWithCompletion:")]
		void PublicChannelDescriptorsWithCompletion (TCHChannelDescriptorPaginatorCompletion completion);

		// -(void)createChannelWithOptions:(NSDictionary<NSString *,id> * _Nullable)options completion:(TCHChannelCompletion _Nullable)completion;
		[Export ("createChannelWithOptions:completion:")]
		void CreateChannelWithOptions ([NullAllowed] NSDictionary<NSString, NSObject> options, [NullAllowed] TCHChannelCompletion completion);

		// -(void)channelWithSidOrUniqueName:(NSString * _Nonnull)sidOrUniqueName completion:(TCHChannelCompletion _Nonnull)completion;
		[Export ("channelWithSidOrUniqueName:completion:")]
		void ChannelWithSidOrUniqueName (string sidOrUniqueName, TCHChannelCompletion completion);
	}

	// @interface TCHJsonAttributes : NSObject
	[BaseType (typeof(NSObject))]
	[DisableDefaultCtor]
	interface TCHJsonAttributes
	{
		// -(instancetype _Null_unspecified)initWithDictionary:(NSDictionary * _Nonnull)dictionary;
		[Export ("initWithDictionary:")]
		IntPtr Constructor (NSDictionary dictionary);

		// -(instancetype _Null_unspecified)initWithArray:(NSArray * _Nonnull)array;
		[Export ("initWithArray:")]
		IntPtr Constructor (NSObject[] array);

		// -(instancetype _Null_unspecified)initWithString:(NSString * _Nonnull)string;
		[Export ("initWithString:")]
		IntPtr Constructor (string @string);

		// -(instancetype _Null_unspecified)initWithNumber:(NSNumber * _Nonnull)number;
		[Export ("initWithNumber:")]
		IntPtr Constructor (NSNumber number);

		// @property (readonly) BOOL isDictionary;
		[Export ("isDictionary")]
		bool IsDictionary { get; }

		// @property (readonly) BOOL isArray;
		[Export ("isArray")]
		bool IsArray { get; }

		// @property (readonly) BOOL isString;
		[Export ("isString")]
		bool IsString { get; }

		// @property (readonly) BOOL isNumber;
		[Export ("isNumber")]
		bool IsNumber { get; }

		// @property (readonly) BOOL isNull;
		[Export ("isNull")]
		bool IsNull { get; }

		// @property (readonly) NSDictionary * _Nullable dictionary;
		[NullAllowed, Export ("dictionary")]
		NSDictionary Dictionary { get; }

		// @property (readonly) NSArray * _Nullable array;
		[NullAllowed, Export ("array")]
		NSObject[] Array { get; }

		// @property (readonly) NSString * _Nullable string;
		[NullAllowed, Export ("string")]
		string String { get; }

		// @property (readonly) NSNumber * _Nullable number;
		[NullAllowed, Export ("number")]
		NSNumber Number { get; }
	}

	// @interface TCHMessage : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHMessage
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable sid;
		[NullAllowed, Export ("sid")]
		string Sid { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable index;
		[NullAllowed, Export ("index", ArgumentSemantic.Copy)]
		NSNumber Index { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable author;
		[NullAllowed, Export ("author")]
		string Author { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable body;
		[NullAllowed, Export ("body")]
		string Body { get; }

		// @property (readonly, assign, nonatomic) TCHMessageType messageType;
		[Export ("messageType", ArgumentSemantic.Assign)]
		TCHMessageType MessageType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable mediaSid;
		[NullAllowed, Export ("mediaSid")]
		string MediaSid { get; }

		// @property (readonly, assign, nonatomic) NSUInteger mediaSize;
		[Export ("mediaSize")]
		nuint MediaSize { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable mediaType;
		[NullAllowed, Export ("mediaType")]
		string MediaType { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable mediaFilename;
		[NullAllowed, Export ("mediaFilename")]
		string MediaFilename { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable memberSid;
		[NullAllowed, Export ("memberSid")]
		string MemberSid { get; }

		// @property (readonly, copy, nonatomic) TCHMember * _Nullable member;
		[NullAllowed, Export ("member", ArgumentSemantic.Copy)]
		TCHMember Member { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable timestamp;
		[NullAllowed, Export ("timestamp")]
		string Timestamp { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable timestampAsDate;
		[NullAllowed, Export ("timestampAsDate", ArgumentSemantic.Strong)]
		NSDate TimestampAsDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable dateUpdated;
		[NullAllowed, Export ("dateUpdated")]
		string DateUpdated { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable dateUpdatedAsDate;
		[NullAllowed, Export ("dateUpdatedAsDate", ArgumentSemantic.Strong)]
		NSDate DateUpdatedAsDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastUpdatedBy;
		[NullAllowed, Export ("lastUpdatedBy")]
		string LastUpdatedBy { get; }

		// -(void)updateBody:(NSString * _Nonnull)body completion:(TCHCompletion _Nullable)completion;
		[Export ("updateBody:completion:")]
		void UpdateBody (string body, [NullAllowed] TCHCompletion completion);

		// -(TCHJsonAttributes * _Nullable)attributes;
		[NullAllowed, Export ("attributes")]
		TCHJsonAttributes Attributes { get; }

		// -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
		[Export ("setAttributes:completion:")]
		void SetAttributes ([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

		// -(BOOL)hasMedia;
		[Export ("hasMedia")]
		bool HasMedia { get; }

		// -(void)getMediaWithOutputStream:(NSOutputStream * _Nonnull)mediaStream onStarted:(TCHMediaOnStarted _Nullable)onStarted onProgress:(TCHMediaOnProgress _Nullable)onProgress onCompleted:(TCHMediaOnCompleted _Nullable)onCompleted completion:(TCHCompletion _Nullable)completion;
		[Export ("getMediaWithOutputStream:onStarted:onProgress:onCompleted:completion:")]
		void GetMediaWithOutputStream (NSOutputStream mediaStream, [NullAllowed] TCHMediaOnStarted onStarted, [NullAllowed] TCHMediaOnProgress onProgress, [NullAllowed] TCHMediaOnCompleted onCompleted, [NullAllowed] TCHCompletion completion);
	}

	// @interface TCHMessageOptions : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHMessageOptions
	{
		// -(instancetype _Nonnull)withBody:(NSString * _Nonnull)body;
		[Export ("withBody:")]
		TCHMessageOptions WithBody (string body);

		// -(instancetype _Nonnull)withMediaStream:(NSInputStream * _Nonnull)mediaStream contentType:(NSString * _Nonnull)contentType defaultFilename:(NSString * _Nullable)defaultFilename onStarted:(TCHMediaOnStarted _Nullable)onStarted onProgress:(TCHMediaOnProgress _Nullable)onProgress onCompleted:(TCHMediaOnCompleted _Nullable)onCompleted;
		[Export ("withMediaStream:contentType:defaultFilename:onStarted:onProgress:onCompleted:")]
		TCHMessageOptions WithMediaStream (NSInputStream mediaStream, string contentType, [NullAllowed] string defaultFilename, [NullAllowed] TCHMediaOnStarted onStarted, [NullAllowed] TCHMediaOnProgress onProgress, [NullAllowed] TCHMediaOnCompleted onCompleted);

		// -(instancetype _Nullable)withAttributes:(TCHJsonAttributes * _Nonnull)attributes completion:(TCHCompletion _Nullable)completion;
		[Export ("withAttributes:completion:")]
		[return: NullAllowed]
		TCHMessageOptions WithAttributes (TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);
	}

	// @interface TCHMessages : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHMessages
	{
		// @property (readonly, copy, nonatomic) NSNumber * _Nullable lastConsumedMessageIndex;
		[NullAllowed, Export ("lastConsumedMessageIndex", ArgumentSemantic.Copy)]
		NSNumber LastConsumedMessageIndex { get; }

		// -(void)sendMessageWithOptions:(TCHMessageOptions * _Nonnull)options completion:(TCHMessageCompletion _Nullable)completion;
		[Export ("sendMessageWithOptions:completion:")]
		void SendMessageWithOptions (TCHMessageOptions options, [NullAllowed] TCHMessageCompletion completion);

		// -(void)removeMessage:(TCHMessage * _Nonnull)message completion:(TCHCompletion _Nullable)completion;
		[Export ("removeMessage:completion:")]
		void RemoveMessage (TCHMessage message, [NullAllowed] TCHCompletion completion);

		// -(void)getLastMessagesWithCount:(NSUInteger)count completion:(TCHMessagesCompletion _Nonnull)completion;
		[Export ("getLastMessagesWithCount:completion:")]
		void GetLastMessagesWithCount (nuint count, TCHMessagesCompletion completion);

		// -(void)getMessagesBefore:(NSUInteger)index withCount:(NSUInteger)count completion:(TCHMessagesCompletion _Nonnull)completion;
		[Export ("getMessagesBefore:withCount:completion:")]
		void GetMessagesBefore (nuint index, nuint count, TCHMessagesCompletion completion);

		// -(void)getMessagesAfter:(NSUInteger)index withCount:(NSUInteger)count completion:(TCHMessagesCompletion _Nonnull)completion;
		[Export ("getMessagesAfter:withCount:completion:")]
		void GetMessagesAfter (nuint index, nuint count, TCHMessagesCompletion completion);

		// -(void)messageWithIndex:(NSNumber * _Nonnull)index completion:(TCHMessageCompletion _Nonnull)completion;
		[Export ("messageWithIndex:completion:")]
		void MessageWithIndex (NSNumber index, TCHMessageCompletion completion);

		// -(void)messageForConsumptionIndex:(NSNumber * _Nonnull)index completion:(TCHMessageCompletion _Nonnull)completion;
		[Export ("messageForConsumptionIndex:completion:")]
		void MessageForConsumptionIndex (NSNumber index, TCHMessageCompletion completion);

		// -(void)setLastConsumedMessageIndex:(NSNumber * _Nonnull)index __attribute__((deprecated("setLastConsumedMessageIndex: has been deprecated please use setLastConsumedMessageIndex:completion: instead")));
		[Export ("setLastConsumedMessageIndex:")]
		void SetLastConsumedMessageIndex (NSNumber index);

		// -(void)setLastConsumedMessageIndex:(NSNumber * _Nonnull)index completion:(TCHCountCompletion _Nullable)completion;
		[Export ("setLastConsumedMessageIndex:completion:")]
		void SetLastConsumedMessageIndex (NSNumber index, [NullAllowed] TCHCountCompletion completion);

		// -(void)advanceLastConsumedMessageIndex:(NSNumber * _Nonnull)index __attribute__((deprecated("advanceLastConsumedMessageIndex: has been deprecated please use advanceLastConsumedMessageIndex:completion: instead")));
		[Export ("advanceLastConsumedMessageIndex:")]
		void AdvanceLastConsumedMessageIndex (NSNumber index);

		// -(void)advanceLastConsumedMessageIndex:(NSNumber * _Nonnull)index completion:(TCHCountCompletion _Nullable)completion;
		[Export ("advanceLastConsumedMessageIndex:completion:")]
		void AdvanceLastConsumedMessageIndex (NSNumber index, [NullAllowed] TCHCountCompletion completion);

		// -(void)setAllMessagesConsumed __attribute__((deprecated("setAllMessagesConsumed has been deprecated please use setAllMessagesConsumedWithCompletion: instead")));
		[Export ("setAllMessagesConsumed")]
		void SetAllMessagesConsumed ();

		// -(void)setAllMessagesConsumedWithCompletion:(TCHCountCompletion _Nullable)completion;
		[Export ("setAllMessagesConsumedWithCompletion:")]
		void SetAllMessagesConsumedWithCompletion ([NullAllowed] TCHCountCompletion completion);

		// -(void)setNoMessagesConsumed __attribute__((deprecated("setNoMessagesConsumed has been deprecated please use setNoMessagesConsumedWithCompletion: instead")));
		[Export ("setNoMessagesConsumed")]
		void SetNoMessagesConsumed ();

		// -(void)setNoMessagesConsumedWithCompletion:(TCHCountCompletion _Nullable)completion;
		[Export ("setNoMessagesConsumedWithCompletion:")]
		void SetNoMessagesConsumedWithCompletion ([NullAllowed] TCHCountCompletion completion);
	}

	// @interface TCHMember : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHMember
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable sid;
		[NullAllowed, Export ("sid")]
		string Sid { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable identity;
		[NullAllowed, Export ("identity", ArgumentSemantic.Strong)]
		string Identity { get; }

		// @property (readonly, nonatomic) TCHMemberType type;
		[Export ("type")]
		TCHMemberType Type { get; }

		// @property (readonly, copy, nonatomic) NSNumber * _Nullable lastConsumedMessageIndex;
		[NullAllowed, Export ("lastConsumedMessageIndex", ArgumentSemantic.Copy)]
		NSNumber LastConsumedMessageIndex { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable lastConsumptionTimestamp;
		[NullAllowed, Export ("lastConsumptionTimestamp")]
		string LastConsumptionTimestamp { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable lastConsumptionTimestampAsDate;
		[NullAllowed, Export ("lastConsumptionTimestampAsDate", ArgumentSemantic.Strong)]
		NSDate LastConsumptionTimestampAsDate { get; }

		// -(TCHJsonAttributes * _Nullable)attributes;
		[NullAllowed, Export ("attributes")]
		TCHJsonAttributes Attributes { get; }

		// -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
		[Export ("setAttributes:completion:")]
		void SetAttributes ([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

		// -(void)userDescriptorWithCompletion:(TCHUserDescriptorCompletion _Nonnull)completion;
		[Export ("userDescriptorWithCompletion:")]
		void UserDescriptorWithCompletion (TCHUserDescriptorCompletion completion);

		// -(void)subscribedUserWithCompletion:(TCHUserCompletion _Nonnull)completion;
		[Export ("subscribedUserWithCompletion:")]
		void SubscribedUserWithCompletion (TCHUserCompletion completion);
	}

	// @interface TCHMembers : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHMembers
	{
		// -(void)membersWithCompletion:(TCHMemberPaginatorCompletion _Nonnull)completion;
		[Export ("membersWithCompletion:")]
		void MembersWithCompletion (TCHMemberPaginatorCompletion completion);

		// -(void)addByIdentity:(NSString * _Nonnull)identity completion:(TCHCompletion _Nullable)completion;
		[Export ("addByIdentity:completion:")]
		void AddByIdentity (string identity, [NullAllowed] TCHCompletion completion);

		// -(void)inviteByIdentity:(NSString * _Nonnull)identity completion:(TCHCompletion _Nullable)completion;
		[Export ("inviteByIdentity:completion:")]
		void InviteByIdentity (string identity, [NullAllowed] TCHCompletion completion);

		// -(void)removeMember:(TCHMember * _Nonnull)member completion:(TCHCompletion _Nullable)completion;
		[Export ("removeMember:completion:")]
		void RemoveMember (TCHMember member, [NullAllowed] TCHCompletion completion);
	}

	// @interface TCHUser : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHUser
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable identity;
		[NullAllowed, Export ("identity")]
		string Identity { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable friendlyName;
		[NullAllowed, Export ("friendlyName")]
		string FriendlyName { get; }

		// -(TCHJsonAttributes * _Nullable)attributes;
		[NullAllowed, Export ("attributes")]
		TCHJsonAttributes Attributes { get; }

		// -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
		[Export ("setAttributes:completion:")]
		void SetAttributes ([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

		// -(void)setFriendlyName:(NSString * _Nullable)friendlyName completion:(TCHCompletion _Nullable)completion;
		[Export ("setFriendlyName:completion:")]
		void SetFriendlyName ([NullAllowed] string friendlyName, [NullAllowed] TCHCompletion completion);

		// -(BOOL)isOnline;
		[Export ("isOnline")]
		bool IsOnline { get; }

		// -(BOOL)isNotifiable;
		[Export ("isNotifiable")]
		bool IsNotifiable { get; }

		// -(BOOL)isSubscribed;
		[Export ("isSubscribed")]
		bool IsSubscribed { get; }

		// -(void)unsubscribe;
		[Export ("unsubscribe")]
		void Unsubscribe ();
	}

	// @interface TCHChannel : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHChannel
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		public TCHChannelDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TCHChannelDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable sid;
		[NullAllowed, Export ("sid")]
		string Sid { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable friendlyName;
		[NullAllowed, Export ("friendlyName")]
		string FriendlyName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable uniqueName;
		[NullAllowed, Export ("uniqueName")]
		string UniqueName { get; }

		// @property (readonly, nonatomic, strong) TCHMessages * _Nullable messages;
		[NullAllowed, Export ("messages", ArgumentSemantic.Strong)]
		public TCHMessages Messages { get; }

		// @property (readonly, nonatomic, strong) TCHMembers * _Nullable members;
		[NullAllowed, Export ("members", ArgumentSemantic.Strong)]
		TCHMembers Members { get; }

		// @property (readonly, assign, nonatomic) TCHChannelSynchronizationStatus synchronizationStatus;
		[Export ("synchronizationStatus", ArgumentSemantic.Assign)]
		TCHChannelSynchronizationStatus SynchronizationStatus { get; }

		// @property (readonly, assign, nonatomic) TCHChannelStatus status;
		[Export ("status", ArgumentSemantic.Assign)]
		TCHChannelStatus Status { get; }

		// @property (readonly, assign, nonatomic) TCHChannelNotificationLevel notificationLevel;
		[Export ("notificationLevel", ArgumentSemantic.Assign)]
		TCHChannelNotificationLevel NotificationLevel { get; }

		// @property (readonly, assign, nonatomic) TCHChannelType type;
		[Export ("type", ArgumentSemantic.Assign)]
		TCHChannelType Type { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable dateCreated;
		[NullAllowed, Export ("dateCreated", ArgumentSemantic.Strong)]
		string DateCreated { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable dateCreatedAsDate;
		[NullAllowed, Export ("dateCreatedAsDate", ArgumentSemantic.Strong)]
		NSDate DateCreatedAsDate { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable createdBy;
		[NullAllowed, Export ("createdBy")]
		string CreatedBy { get; }

		// @property (readonly, nonatomic, strong) NSString * _Nullable dateUpdated;
		[NullAllowed, Export ("dateUpdated", ArgumentSemantic.Strong)]
		string DateUpdated { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable dateUpdatedAsDate;
		[NullAllowed, Export ("dateUpdatedAsDate", ArgumentSemantic.Strong)]
		NSDate DateUpdatedAsDate { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable lastMessageDate;
		[NullAllowed, Export ("lastMessageDate", ArgumentSemantic.Strong)]
		NSDate LastMessageDate { get; }

		// @property (readonly, nonatomic, strong) NSNumber * _Nullable lastMessageIndex;
		[NullAllowed, Export ("lastMessageIndex", ArgumentSemantic.Strong)]
		NSNumber LastMessageIndex { get; }

		// -(TCHJsonAttributes * _Nullable)attributes;
		[NullAllowed, Export ("attributes")]
		TCHJsonAttributes Attributes { get; }

		// -(void)setAttributes:(TCHJsonAttributes * _Nullable)attributes completion:(TCHCompletion _Nullable)completion;
		[Export ("setAttributes:completion:")]
		void SetAttributes ([NullAllowed] TCHJsonAttributes attributes, [NullAllowed] TCHCompletion completion);

		// -(void)setFriendlyName:(NSString * _Nullable)friendlyName completion:(TCHCompletion _Nullable)completion;
		[Export ("setFriendlyName:completion:")]
		void SetFriendlyName ([NullAllowed] string friendlyName, [NullAllowed] TCHCompletion completion);

		// -(void)setUniqueName:(NSString * _Nullable)uniqueName completion:(TCHCompletion _Nullable)completion;
		[Export ("setUniqueName:completion:")]
		void SetUniqueName ([NullAllowed] string uniqueName, [NullAllowed] TCHCompletion completion);

		// -(void)setNotificationLevel:(TCHChannelNotificationLevel)notificationLevel completion:(TCHCompletion _Nullable)completion;
		[Export ("setNotificationLevel:completion:")]
		void SetNotificationLevel (TCHChannelNotificationLevel notificationLevel, [NullAllowed] TCHCompletion completion);

		// -(void)joinWithCompletion:(TCHCompletion _Nullable)completion;
		[Export ("joinWithCompletion:")]
		void JoinWithCompletion ([NullAllowed] TCHCompletion completion);

		// -(void)declineInvitationWithCompletion:(TCHCompletion _Nullable)completion;
		[Export ("declineInvitationWithCompletion:")]
		void DeclineInvitationWithCompletion ([NullAllowed] TCHCompletion completion);

		// -(void)leaveWithCompletion:(TCHCompletion _Nullable)completion;
		[Export ("leaveWithCompletion:")]
		void LeaveWithCompletion ([NullAllowed] TCHCompletion completion);

		// -(void)destroyWithCompletion:(TCHCompletion _Nullable)completion;
		[Export ("destroyWithCompletion:")]
		void DestroyWithCompletion ([NullAllowed] TCHCompletion completion);

		// -(void)typing;
		[Export ("typing")]
		void Typing ();

		// -(TCHMember * _Nullable)memberWithIdentity:(NSString * _Nonnull)identity;
		[Export ("memberWithIdentity:")]
		[return: NullAllowed]
		TCHMember MemberWithIdentity (string identity);

		// -(void)getUnconsumedMessagesCountWithCompletion:(TCHCountCompletion _Nonnull)completion;
		[Export ("getUnconsumedMessagesCountWithCompletion:")]
		void GetUnconsumedMessagesCountWithCompletion (TCHCountCompletion completion);

		// -(void)getMessagesCountWithCompletion:(TCHCountCompletion _Nonnull)completion;
		[Export ("getMessagesCountWithCompletion:")]
		void GetMessagesCountWithCompletion (TCHCountCompletion completion);

		// -(void)getMembersCountWithCompletion:(TCHCountCompletion _Nonnull)completion;
		[Export ("getMembersCountWithCompletion:")]
		void GetMembersCountWithCompletion (TCHCountCompletion completion);
	}

	// @protocol TCHChannelDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TCHChannelDelegate
	{
		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel updated:(TCHChannelUpdate)updated;
		[Export ("chatClient:channel:updated:")]
		void ChannelUpdated (TwilioChatClient client, TCHChannel channel, TCHChannelUpdate updated);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channelDeleted:(TCHChannel * _Nonnull)channel;
		[Export ("chatClient:channelDeleted:")]
		void ChannelDeleted (TwilioChatClient client, TCHChannel channel);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel synchronizationStatusUpdated:(TCHChannelSynchronizationStatus)status;
		[Export ("chatClient:channel:synchronizationStatusUpdated:")]
		void ChannelSynchronizationStatusUpdated(TwilioChatClient client, TCHChannel channel, TCHChannelSynchronizationStatus status);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel memberJoined:(TCHMember * _Nonnull)member;
		[Export ("chatClient:channel:memberJoined:")]
		void ChannelMemberJoined (TwilioChatClient client, TCHChannel channel, TCHMember member);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member updated:(TCHMemberUpdate)updated;
		[Export ("chatClient:channel:member:updated:")]
		void ChannelMemberUpdated (TwilioChatClient client, TCHChannel channel, TCHMember member, TCHMemberUpdate updated);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel memberLeft:(TCHMember * _Nonnull)member;
        [Export("chatClient:channel:memberLeft:")]
        void ChannelMemberLeft(TwilioChatClient client, TCHChannel channel, TCHMember member);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel messageAdded:(TCHMessage * _Nonnull)message;
        [Export ("chatClient:channel:messageAdded:")]
		void ChannelMessageAdded (TwilioChatClient client, TCHChannel channel, TCHMessage message);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel message:(TCHMessage * _Nonnull)message updated:(TCHMessageUpdate)updated;
		[Export ("chatClient:channel:message:updated:")]
		void ChannelMessageUpdated (TwilioChatClient client, TCHChannel channel, TCHMessage message, TCHMessageUpdate updated);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel messageDeleted:(TCHMessage * _Nonnull)message;
        [Export("chatClient:channel:messageDeleted:")]
        void ChannelMessageDeleted(TwilioChatClient client, TCHChannel channel, TCHMessage message);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client typingStartedOnChannel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member;
        [Export ("chatClient:typingStartedOnChannel:member:")]
		void TypingStartedOnChannel (TwilioChatClient client, TCHChannel channel, TCHMember member);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client typingEndedOnChannel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member;
		[Export ("chatClient:typingEndedOnChannel:member:")]
		void TypingEndedOnChannel (TwilioChatClient client, TCHChannel channel, TCHMember member);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member user:(TCHUser * _Nonnull)user updated:(TCHUserUpdate)updated;
		[Export ("chatClient:channel:member:user:updated:")]
		void ChannelMemberUserUpdated (TwilioChatClient client, TCHChannel channel, TCHMember member, TCHUser user, TCHUserUpdate updated);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member userSubscribed:(TCHUser * _Nonnull)user;
		[Export ("chatClient:channel:member:userSubscribed:")]
		void ChannelMemberUserSubscribed (TwilioChatClient client, TCHChannel channel, TCHMember member, TCHUser user);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member userUnsubscribed:(TCHUser * _Nonnull)user;
        [Export("chatClient:channel:member:userUnsubscribed:")]
        void ChannelMemberUserUnsubscribed(TwilioChatClient client, TCHChannel channel, TCHMember member, TCHUser user);
    }

	// @interface TCHChannelDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHChannelDescriptor
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable sid;
		[NullAllowed, Export ("sid")]
		string Sid { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable friendlyName;
		[NullAllowed, Export ("friendlyName")]
		string FriendlyName { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable uniqueName;
		[NullAllowed, Export ("uniqueName")]
		string UniqueName { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable dateCreated;
		[NullAllowed, Export ("dateCreated", ArgumentSemantic.Strong)]
		NSDate DateCreated { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable createdBy;
		[NullAllowed, Export ("createdBy")]
		string CreatedBy { get; }

		// @property (readonly, nonatomic, strong) NSDate * _Nullable dateUpdated;
		[NullAllowed, Export ("dateUpdated", ArgumentSemantic.Strong)]
		NSDate DateUpdated { get; }

		// -(TCHJsonAttributes * _Nullable)attributes;
		[NullAllowed, Export ("attributes")]
		TCHJsonAttributes Attributes { get; }

		// -(NSUInteger)messagesCount;
		[Export ("messagesCount")]
		nuint MessagesCount { get; }

		// -(NSUInteger)membersCount;
		[Export ("membersCount")]
		nuint MembersCount { get; }

		// -(void)channelWithCompletion:(TCHChannelCompletion _Nonnull)completion;
		[Export ("channelWithCompletion:")]
		void ChannelWithCompletion (TCHChannelCompletion completion);
	}

	// @interface TCHChannelDescriptorPaginator : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHChannelDescriptorPaginator
	{
		// -(NSArray<TCHChannelDescriptor *> * _Nonnull)items;
		[Export ("items")]
		TCHChannelDescriptor[] Items { get; }

		// -(BOOL)hasNextPage;
		[Export ("hasNextPage")]
		bool HasNextPage { get; }

		// -(void)requestNextPageWithCompletion:(TCHChannelDescriptorPaginatorCompletion _Nonnull)completion;
		[Export ("requestNextPageWithCompletion:")]
		void RequestNextPageWithCompletion (TCHChannelDescriptorPaginatorCompletion completion);
	}

	// @interface TCHMemberPaginator : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHMemberPaginator
	{
		// -(NSArray<TCHMember *> * _Nonnull)items;
		[Export ("items")]
		TCHMember[] Items { get; }

		// -(BOOL)hasNextPage;
		[Export ("hasNextPage")]
		bool HasNextPage { get; }

		// -(void)requestNextPageWithCompletion:(TCHMemberPaginatorCompletion _Nonnull)completion;
		[Export ("requestNextPageWithCompletion:")]
		void RequestNextPageWithCompletion (TCHMemberPaginatorCompletion completion);
	}

	// @interface TCHUsers : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHUsers
	{
		// -(void)userDescriptorsForChannel:(TCHChannel * _Nonnull)channel completion:(TCHUserDescriptorPaginatorCompletion _Nonnull)completion;
		[Export ("userDescriptorsForChannel:completion:")]
		void UserDescriptorsForChannel (TCHChannel channel, TCHUserDescriptorPaginatorCompletion completion);

		// -(void)userDescriptorWithIdentity:(NSString * _Nonnull)identity completion:(TCHUserDescriptorCompletion _Nonnull)completion;
		[Export ("userDescriptorWithIdentity:completion:")]
		void UserDescriptorWithIdentity (string identity, TCHUserDescriptorCompletion completion);

		// -(void)subscribedUserWithIdentity:(NSString * _Nonnull)identity completion:(TCHUserCompletion _Nonnull)completion;
		[Export ("subscribedUserWithIdentity:completion:")]
		void SubscribedUserWithIdentity (string identity, TCHUserCompletion completion);

		// -(NSArray<TCHUser *> * _Nonnull)subscribedUsers;
		[Export ("subscribedUsers")]
		TCHUser[] SubscribedUsers { get; }
	}

	// @interface TCHUserDescriptor : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHUserDescriptor
	{
		// @property (readonly, copy, nonatomic) NSString * _Nullable identity;
		[NullAllowed, Export ("identity")]
		string Identity { get; }

		// @property (readonly, copy, nonatomic) NSString * _Nullable friendlyName;
		[NullAllowed, Export ("friendlyName")]
		string FriendlyName { get; }

		// -(TCHJsonAttributes * _Nullable)attributes;
		[NullAllowed, Export ("attributes")]
		TCHJsonAttributes Attributes { get; }

		// -(BOOL)isOnline;
		[Export ("isOnline")]
		bool IsOnline { get; }

		// -(BOOL)isNotifiable;
		[Export ("isNotifiable")]
		bool IsNotifiable { get; }

		// -(void)subscribeWithCompletion:(TCHUserCompletion _Nullable)completion;
		[Export ("subscribeWithCompletion:")]
		void SubscribeWithCompletion ([NullAllowed] TCHUserCompletion completion);
	}

	// @interface TCHUserDescriptorPaginator : NSObject
	[BaseType (typeof(NSObject))]
	interface TCHUserDescriptorPaginator
	{
		// -(NSArray<TCHUserDescriptor *> * _Nonnull)items;
		[Export ("items")]
		TCHUserDescriptor[] Items { get; }

		// -(BOOL)hasNextPage;
		[Export ("hasNextPage")]
		bool HasNextPage { get; }

		// -(void)requestNextPageWithCompletion:(TCHUserDescriptorPaginatorCompletion _Nonnull)completion;
		[Export ("requestNextPageWithCompletion:")]
		void RequestNextPageWithCompletion (TCHUserDescriptorPaginatorCompletion completion);
	}

	// @interface TwilioChatClient : NSObject
	[BaseType (typeof(NSObject))]
	interface TwilioChatClient
	{
		[Wrap ("WeakDelegate")]
		[NullAllowed]
		TwilioChatClientDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<TwilioChatClientDelegate> _Nullable delegate;
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (readonly, nonatomic, strong) TCHUser * _Nullable user;
		[NullAllowed, Export ("user", ArgumentSemantic.Strong)]
		TCHUser User { get; }

		// @property (readonly, assign, nonatomic) TCHClientConnectionState connectionState;
		[Export ("connectionState", ArgumentSemantic.Assign)]
		TCHClientConnectionState ConnectionState { get; }

		// @property (readonly, assign, nonatomic) TCHClientSynchronizationStatus synchronizationStatus;
		[Export ("synchronizationStatus", ArgumentSemantic.Assign)]
		TCHClientSynchronizationStatus SynchronizationStatus { get; }

		// +(TCHLogLevel)logLevel;
		// +(void)setLogLevel:(TCHLogLevel)logLevel;
		[Static]
		[Export ("logLevel")]
		TCHLogLevel LogLevel { get; set; }

		// +(void)chatClientWithToken:(NSString * _Nonnull)token properties:(TwilioChatClientProperties * _Nullable)properties delegate:(id<TwilioChatClientDelegate> _Nullable)delegate completion:(TCHTwilioClientCompletion _Nonnull)completion;
		[Static]
		[Export ("chatClientWithToken:properties:delegate:completion:")]
		void ChatClientWithToken (string token, [NullAllowed] TwilioChatClientProperties properties, [NullAllowed] TwilioChatClientDelegate @delegate, TCHTwilioClientCompletion completion);

		// +(NSString * _Nonnull)sdkName;
		[Static]
		[Export ("sdkName")]
		string SdkName { get; }

		// +(NSString * _Nonnull)sdkVersion;
		[Static]
		[Export ("sdkVersion")]
		string SdkVersion { get; }

		// -(NSString * _Nonnull)version __attribute__((deprecated("Instance method version is deprecated, please see the class method sdkVersion.")));
		[Export ("version")]
		string Version { get; }

		// -(void)updateToken:(NSString * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
		[Export ("updateToken:completion:")]
		void UpdateToken (string token, [NullAllowed] TCHCompletion completion);

		// -(TCHChannels * _Nullable)channelsList;
		[NullAllowed, Export ("channelsList")]
		TCHChannels ChannelsList { get; }

		// -(TCHUsers * _Nullable)users;
		[NullAllowed, Export ("users")]
		TCHUsers Users { get; }

		// -(void)registerWithNotificationToken:(NSData * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
		[Export ("registerWithNotificationToken:completion:")]
		void RegisterWithNotificationToken (NSData token, [NullAllowed] TCHCompletion completion);

		// -(void)deregisterWithNotificationToken:(NSData * _Nonnull)token completion:(TCHCompletion _Nullable)completion;
		[Export ("deregisterWithNotificationToken:completion:")]
		void DeregisterWithNotificationToken (NSData token, [NullAllowed] TCHCompletion completion);

		// -(void)handleNotification:(NSDictionary * _Nonnull)notification completion:(TCHCompletion _Nullable)completion;
		[Export ("handleNotification:completion:")]
		void HandleNotification (NSDictionary notification, [NullAllowed] TCHCompletion completion);

		// -(BOOL)isReachabilityEnabled;
		[Export ("isReachabilityEnabled")]
		bool IsReachabilityEnabled { get; }

		// -(void)shutdown;
		[Export ("shutdown")]
		void Shutdown ();
	}

	// @interface TwilioChatClientProperties : NSObject
	[BaseType (typeof(NSObject))]
	interface TwilioChatClientProperties
	{
		// @property (copy, nonatomic) NSString * _Nonnull region;
		[Export ("region")]
		string Region { get; set; }
	}

	// @protocol TwilioChatClientDelegate <NSObject>
	[Protocol, Model]
	[BaseType (typeof(NSObject))]
	interface TwilioChatClientDelegate
	{
		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client connectionStateUpdated:(TCHClientConnectionState)state;
		[Export ("chatClient:connectionStateUpdated:")]
		void ConnectionStateUpdated (TwilioChatClient client, TCHClientConnectionState state);

		// @optional -(void)chatClientTokenExpired:(TwilioChatClient * _Nonnull)client;
		[Export ("chatClientTokenExpired:")]
		void ChatClientTokenExpired (TwilioChatClient client);

		// @optional -(void)chatClientTokenWillExpire:(TwilioChatClient * _Nonnull)client;
		[Export ("chatClientTokenWillExpire:")]
		void ChatClientTokenWillExpire (TwilioChatClient client);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client synchronizationStatusUpdated:(TCHClientSynchronizationStatus)status;
		[Export ("chatClient:synchronizationStatusUpdated:")]
		void SynchronizationStatusUpdated(TwilioChatClient client, TCHClientSynchronizationStatus status);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channelAdded:(TCHChannel * _Nonnull)channel;
		[Export ("chatClient:channelAdded:")]
		void ChannelAdded (TwilioChatClient client, TCHChannel channel);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel updated:(TCHChannelUpdate)updated;
		[Export ("chatClient:channel:updated:")]
		void ChannelUpdated (TwilioChatClient client, TCHChannel channel, TCHChannelUpdate updated);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel synchronizationStatusUpdated:(TCHChannelSynchronizationStatus)status;
		[Export ("chatClient:channel:synchronizationStatusUpdated:")]
		void ChannelSynchronizationStatusUpdated(TwilioChatClient client, TCHChannel channel, TCHChannelSynchronizationStatus status);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channelDeleted:(TCHChannel * _Nonnull)channel;
        [Export("chatClient:channelDeleted:")]
        void ChannelDeleted(TwilioChatClient client, TCHChannel channel);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel memberJoined:(TCHMember * _Nonnull)member;
        [Export ("chatClient:channel:memberJoined:")]
		void ChannelMemberJoined (TwilioChatClient client, TCHChannel channel, TCHMember member);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member updated:(TCHMemberUpdate)updated;
		[Export ("chatClient:channel:member:updated:")]
		void ChannelMemberUpdated (TwilioChatClient client, TCHChannel channel, TCHMember member, TCHMemberUpdate updated);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel memberLeft:(TCHMember * _Nonnull)member;
        [Export("chatClient:channel:memberLeft:")]
        void ChannelMemberLeft(TwilioChatClient client, TCHChannel channel, TCHMember member);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel messageAdded:(TCHMessage * _Nonnull)message;
        [Export ("chatClient:channel:messageAdded:")]
		void ChatClient (TwilioChatClient client, TCHChannel channel, TCHMessage message);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel message:(TCHMessage * _Nonnull)message updated:(TCHMessageUpdate)updated;
		[Export ("chatClient:channel:message:updated:")]
		void ChatClient (TwilioChatClient client, TCHChannel channel, TCHMessage message, TCHMessageUpdate updated);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client channel:(TCHChannel * _Nonnull)channel messageDeleted:(TCHMessage * _Nonnull)message;
        [Export("chatClient:channel:messageDeleted:")]
        void ChannelMessageDeleted(TwilioChatClient client, TCHChannel channel, TCHMessage message);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client errorReceived:(TCHError * _Nonnull)error;
        [Export ("chatClient:errorReceived:")]
		void ChatClient (TwilioChatClient client, TCHError error);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client typingStartedOnChannel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member;
        [Export("chatClient:typingStartedOnChannel:member:")]
        void typingStartedOnChannelMember(TwilioChatClient client, TCHChannel channel, TCHMember member);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client typingEndedOnChannel:(TCHChannel * _Nonnull)channel member:(TCHMember * _Nonnull)member;
        [Export("chatClient:typingEndedOnChannel:member:")]
        void TypingEndedOnChannelMember(TwilioChatClient client, TCHChannel channel, TCHMember member);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client notificationNewMessageReceivedForChannelSid:(NSString * _Nonnull)channelSid messageIndex:(NSUInteger)messageIndex;
        [Export ("chatClient:notificationNewMessageReceivedForChannelSid:messageIndex:")]
		void NotificationNewMessageReceivedForChannelSidMessageIndex(TwilioChatClient client, string channelSid, nuint messageIndex);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client notificationAddedToChannelWithSid:(NSString * _Nonnull)channelSid;
		[Export ("chatClient:notificationAddedToChannelWithSid:")]
		void NotificationAddedToChannelWithSid(TwilioChatClient client, string channelSid);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client notificationInvitedToChannelWithSid:(NSString * _Nonnull)channelSid;
        [Export("chatClient:notificationInvitedToChannelWithSid:")]
        void NotificationInvitedToChannelWithSid(TwilioChatClient client, string channelSid);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client notificationRemovedFromChannelWithSid:(NSString * _Nonnull)channelSid;
        [Export("chatClient:notificationRemovedFromChannelWithSid:")]
        void NotificationRemovedFromChannelWithSid(TwilioChatClient client, string channelSid);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client notificationUpdatedBadgeCount:(NSUInteger)badgeCount;
        [Export ("chatClient:notificationUpdatedBadgeCount:")]
		void NotificationUpdatedBadgeCount (TwilioChatClient client, nuint badgeCount);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client user:(TCHUser * _Nonnull)user updated:(TCHUserUpdate)updated;
		[Export ("chatClient:user:updated:")]
		void UserUpdated (TwilioChatClient client, TCHUser user, TCHUserUpdate updated);

		// @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client userSubscribed:(TCHUser * _Nonnull)user;
		[Export ("chatClient:userSubscribed:")]
		void UserSubscribed (TwilioChatClient client, TCHUser user);

        // @optional -(void)chatClient:(TwilioChatClient * _Nonnull)client userUnsubscribed:(TCHUser * _Nonnull)user;
        [Export("chatClient:userUnsubscribed:")]
        void UserUnsubscribed(TwilioChatClient client, TCHUser user);
    }
}
