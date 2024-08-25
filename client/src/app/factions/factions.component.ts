import { Component } from '@angular/core';

@Component({
  selector: 'app-factions',
  templateUrl: './factions.component.html',
  styleUrls: ['./factions.component.css']
})
export class FactionsComponent implements OnInit {
  members: Member[] = [];

  constructor(private memberService: MemberService) {}

  ngOnInit() : void{
    this.loadMembers();
  }

  loadMembers(){
    this.membersService.getMembers().subscribe({
      next: members => this.members = members
    })
    }

}
