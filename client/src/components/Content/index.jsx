import React from 'react'
import Banner from '../Banner'
import CategoryProduct from '../catergory/CategoryProduct'
import TitleFeatured from '../Featured'
import ProductItem from '../ProductItem'
import {useState, useEffect} from 'react';


const Content = () => {
    const [products, setProducts] = useState([]);
    useEffect(() => {
        const fetchData = async () => {
          const data = await fetch(`https://dummyjson.com/products`);
          const json = await data.json();
          setProducts(json.products);
        };
        fetchData();
      }, []);
  return (
    <div>
        <div className="product">

            <TitleFeatured  label="PC GEARVN - MIỄN PHÍ GIAO HÀNG TOÀN QUỐC" />
            <div className="grid grid-cols-5 gap-3">
              <ProductItem />
              <ProductItem />
              <ProductItem />
              <ProductItem />
              <ProductItem />
            </div>
            <br />
            <TitleFeatured  label="LAPTOP GAMING BÁN CHẠY" />
            <div className="grid grid-cols-5 gap-3">
                {products.map((item, index) => {
                return <ProductItem key={index}/>;
              })}
            </div>
        </div>
    </div>
  )
}

export default Content