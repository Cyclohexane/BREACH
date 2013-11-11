//  
//  DoorLockButton.cs
//  
//  Author:
//       Justin Bool <booljayj@gmail.com>
// 
//  Copyright (c) 2013 
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using UnityEngine;
using System.Collections;

public class DoorLockButton : MonoBehaviour {
	public Door door;
	
	UILabel label;
	
	void Start() {
		label = GetComponentInChildren<UILabel>();
		door.DoorLocked += DoorLock;
		door.DoorUnlocked += DoorUnlock;
	}
	
	void OnClick() {
		door.Locked = !door.Locked;
	}
	
	void DoorLock(Door d) {
		label.text = "Locked";
		label.color = Color.red;
	}
	
	void DoorUnlock(Door d) {
		label.text = "Unlocked";
		label.color = Color.green;
	}
}

