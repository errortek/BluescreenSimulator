# BluescreenSimulator
This is a simple Bluescreen Simulator for Windows with lots of customizable features. It will not crash your PC; it just displays a full screen window.

## Cannot exit the simulated BSOD?

- Press F7.
- If that does not work, try Fn+F7.
- If that does not work either, click anywhere once, then try F7 and Fn+F7 again.
- By now, you should have exited the screen. This absolutely has to work.

## About anti-virus detection

Sometimes, BluescreenSimulator (and especially its generated EXE files) will be flagged as malware by several anti-virus programs (Avast, AVG, Norton, McAfee, Windows Defender, etc.), this, however, is a false positive.

3 things cause this to happen:
a) Because the program executable isn't signed
b) Some antiviruses detect this as a joke program (which it is)
c) The keyboard hook used to inhibit key presses looks suspicious to many heuristics

If downloaded from our(!) GitHub, the program is safe to use (we cannot give this promise if you download it from somewhere else!). It is okay if you do not trust us; you can always go ahead and compile it yourself.

For a tutorial on how to exclude this program from your antivirus so it can run anyway, check out these links:

    Windows Defender: https://support.microsoft.com/en-us/windows/add-an-exclusion-to-windows-security-811816c0-4dfd-af4a-47e4-c301afe13b26
    Avast: https://support.avast.com/en-ww/article/Antivirus-scan-exclusions#pc
    AVG: https://support.avg.com/SupportArticleView?l=en&urlName=avg-antivirus-scan-exclusion
    Norton: https://support.norton.com/sp/en/us/home/current/solutions/v3672136
    McAfee: https://www.mcafee.com/support/?page=shell&shell=article-view&articleId=TS102056
    For other antiviruses, try searching for "<antivirus name> add exception"

## How to contribute:
- Fork the project
- Clone your forked project to your hard drive using one of the following commands:
	-  `git clone git@github.com:YourName/BluescreenSimulator.git`
	-  `git clone https://github.com/YourName/BluescreenSimulator.git`
- Create a new branch:
	- `git checkout -b  ANameDescribingYourBranch`
- Commit and push your changes regularly:
	- `git add .`
	- `git commit -m "Commit message explaining your changes"`
	- `git push`
- When you're done, create a Pull Request from your repository to this repository's master branch.

## What to do if this is flagged as malware by an AV?

If you receive a notification from Defender or from another AV saying that this is a threat, just put it on the whitelist (in Defender, it's called 'Allowed Threats') - this is not malware<br>
Example of a detection - Detection in Windows Defender:
![image](https://user-images.githubusercontent.com/100033309/236887017-d03a448f-bce2-4c3b-aee3-570b863a1b52.png)
(Once again, the software is *nothing* to be afraid of, as shown in the Defender screenshot, it's just a 'joke program', so it's nothing serious (not malware!))
