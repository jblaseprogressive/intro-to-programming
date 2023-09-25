import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-heading',
  standalone: true,
  imports: [CommonModule],
  template: `
    <p>
      heading works!
    </p>
  `,
  styles: [
  ]
})
export class HeadingComponent {

}
