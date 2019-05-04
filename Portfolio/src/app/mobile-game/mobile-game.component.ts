import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-mobile-game',
  templateUrl: './mobile-game.component.html',
  styleUrls: ['./mobile-game.component.less']
})
export class MobileGameComponent {
  @Input() name:string;
  @Input() description:string;
  @Input() image_left:string;
  @Input() image_center:string;
  @Input() image_right:string;
}
