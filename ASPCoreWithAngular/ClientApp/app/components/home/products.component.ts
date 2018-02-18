import { Component, Inject } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { Router, ActivatedRoute } from '@angular/router';
import { ProductService } from '../../services/productservice.service';
import { Product } from './product';

@Component({
    selector: 'products',
    templateUrl: './products.component.html'
})
export class ProductsComponent {
    products: Product[];

    constructor(public http: Http, private _router: Router, private _productService: ProductService) {
        this.getProducts();
    }

    getProducts() {
        this._productService.getProducts().subscribe(
            data => this.products = data
        )
    }
}