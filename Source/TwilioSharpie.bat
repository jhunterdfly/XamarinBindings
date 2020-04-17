# code to bind sdk files with Sharpie.
#run one level above root folder of solution


root=/Users/johnhunter/Projects
binding=$root/Bindings.Sample2/Twilio.Bindings.iOS

#sudo xcode-select --switch "/Applications/Xcode-11.2.app/Contents/Developer"

sdk=iphoneos13.2

sharpie bind -output $binding/TwilioChatClient  -namespace Twilio.Chat.Client  -framework $binding/"Native References"/TwilioChatClient.framework  -sdk $sdk  -scope Lib

#sudo xcode-select --reset


