import React from 'react'
import Banner from '../Banner'
import CategoryProduct from '../catergory/CategoryProduct'
import TitleFeatured from '../Featured'
import ProductItem from '../ProductItem'
import {useState, useEffect} from 'react';
import { getProduct } from '../../app/services/adminService'


const Content = () => {
  // const [data, setData] = useState([]);


  // useEffect(() => {
  //   const getAllProduct = async () => {
  //     try {
  //       const data = await getProduct();
  //       setData(data.data);
  //       // console.log(data);
  //     } catch (error) {
  //       console.log(error.message);
  //     }
  //   }

  //   getAllProduct(); 
  // }, []);
  return (
    <div>
        <div className="product">

            <TitleFeatured  label="PC GEARVN - MIỄN PHÍ GIAO HÀNG TOÀN QUỐC" />
            <div className="grid grid-cols-5 gap-3">
              {/* <ProductItem /> */}
              {/* <ProductItem />
              <ProductItem />
              <ProductItem />
              <ProductItem /> */}
            </div>
            <br />
            <TitleFeatured  label="LAPTOP GAMING BÁN CHẠY" />
            <div className="grid grid-cols-5 gap-3">
                {/* {data.map((product) => {
                return <ProductItem product={product} key={product.id}/>;
              })} */}
              <ProductItem />;
            </div>
        </div>
    </div>
  )
}

export default Content