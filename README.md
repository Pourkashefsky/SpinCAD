# SpinCAD
(Or sometimes as **SpinCAD-Pro** or **SpinCAD+**) Not to be confused with [SpinCAD-Designer](https://github.com/HolyCityAudio/SpinCAD-Designer) or [SpinCAD-Builder](https://github.com/HolyCityAudio/SpinCAD-Builder) or [SpinASM](https://github.com/yann-ygn/vscode-spinasm).

* C#.NET Framework V4.8.
* DevExpress WinForms Controls/Components V24.2.

**■ Introduction**

Powerful UI to design, program and simulate "Spin Semiconductor" products (currently FV-1 stereo DSP chip workspace only).

This is an open project to integrate a block-diagram design environment plus its compiler and a rich simulator, dedicated for today's modern competent users, away from the clutter and assembly language.

If you feel relevant to developing this piece of machine, all collaborations are welcome.

**■  Manual**

Overall arrangement is a "Dashboard" equipped with 2 sidebars. "Project" manager at the left and "Simulator" and "Preferences" both at right. In the middle of the dashboard "Designer" contains block diagram canvas for 8 patches. "Toolbox" and "Properties" grid ("Inspector" in some cases) which are fixed for 8 slots.

Note that project manager (or "Home", or "Navigator" (all subject-noun ending with -or looks better)) covers instructions and memory usage this time. Patches can be imported or exported invdividually with a proper file extension like *.spnptc distinct to project file extension which was *.spnprj.

"Simulator" meets all required mechanism to provide a complete close-to-reality-experience to the user next to "Preferences" both can make patch selecting, parameter control adjusting, choosing input and output device, feeding sample audio, manipulating main clock, recording and saving audio, monitoring waveforms, spectrums and phasescopes possible.

"Compiler" supports old assembly view then binary/hexadecimal view. It is expected that not only "Current project"→"ASM"→"HEX" is possible but also "HEX"→"ASM"→"Open in designer" would be as much as possible (Decompiling). A built-in memory programmer with its driver (COM port if there were no devices available) can be finish the matter in a good satisfying way.
