#!/bin/sh
export ANDROID_NDK_HOME=/Users/chunchuantu/Library/Android/sdk/ndk/21.4.7075529
export NDK_ROOT=ANDROID_NDK_HOME=/Users/chunchuantu/Library/Android/sdk/ndk/21.4.7075529
export ANDROID_HOME=/Users/chunchuantu/Library/Android/sdk/
export ANDROID_PLATFORM=21
export JAVA_HOME=`/usr/libexec/java_home -v 11`

python3 scripts/build_scripts/build_zips.py   --platform=android --architecture=arm64-v8a --architecture=armeabi-v7a --apis=analytics,auth,crashlytics,dynamic_links,firestore,functions,installations,messaging,remote_config  --unity_root=/Applications/Unity2018.4
