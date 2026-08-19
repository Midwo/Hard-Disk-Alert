# Hard Disk Alert
A lightweight Windows tool for automated disk-space monitoring on local or server drives.

## 1. Overview

Hard Disk Alert monitors selected drives and automatically sends email notifications to IT staff when free space drops below a configured threshold.
The application is designed as a practical internal utility for system administrators.

## 2. Features
  * Automated email alerts - notifications sent when a disk reaches critically low free space.
  * Per-disk thresholds - each drive can be configured with its own minimum free‑space limit.
  * Recipient management - add, edit, or remove email addresses used for alert delivery.
  * Persistent configuration - settings stored in the Windows Registry and a TXT file for quick loading.
  * Simple administrative UI - clear interface for monitoring drives, configuring alerts, and managing recipients.
    
## 3. Tech Stack
* C#
* Windows Forms
* Windows Registry
* TXT storage (email list)
* SMTP

## 4. Screenshots
### 1. Monitoring Dashboard
<img src="https://github.com/Midwo/Hard-Disk-Alert/blob/master/Monitoring%20dysk%C3%B3w%20twardych/HardDisk1.png" width="700" alt="Main Window (Windows Forms)">

### 2. SMTP Configuration
SMTP setup with address, password, signature, server details, and connection test.
<br>
<img src="https://github.com/Midwo/Hard-Disk-Alert/blob/master/Monitoring%20dysk%C3%B3w%20twardych/HardDisk2.png" width="500" alt="View email conf">

### 3. Recipient List (IT Department)
<img src="https://github.com/Midwo/Hard-Disk-Alert/blob/master/Monitoring%20dysk%C3%B3w%20twardych/HardDisk3.png" width="500" alt="View email list IT">

### 4. Example Notification (Email)
<br>
<img src="https://github.com/Midwo/Hard-Disk-Alert/blob/master/Monitoring%20dysk%C3%B3w%20twardych/HardDisk4.png" width="500" alt="View report 1">
<img src="https://github.com/Midwo/Hard-Disk-Alert/blob/master/Monitoring%20dysk%C3%B3w%20twardych/HardDisk5.png" width="500" alt="View report 2">

