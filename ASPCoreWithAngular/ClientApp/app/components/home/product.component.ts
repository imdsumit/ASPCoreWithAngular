import { Component, Input } from '@angular/core';
import { Product } from './product';

@Component({
    selector: '[product]',
    templateUrl: './product.component.html'
})
export class ProductComponent {
    @Input() product: Product;
}