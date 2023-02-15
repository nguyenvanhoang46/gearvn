import React from 'react'
import Banner from '../Banner'
import CategoryProduct from '../catergory/CategoryProduct'
import TitleFeatured from '../Featured'
import ProductItem from '../ProductItem'
import { useState, useEffect } from 'react';
import { getProduct } from '../../app/services/adminService'
import { useQuery } from 'react-query';
import { useSearchParams } from "react-router-dom";

const Content = () => {
  const [page, setPage] = useState(1)
  const [limit, setLimit] = useState(5)
  const { data, isLoading } = useQuery(['GET_PRODUCT_API', page, limit], () => getProduct({ page, limit }))
  let [searchParams, setSearchParams] = useSearchParams();
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

  useEffect(() => {
    const page = searchParams.get('page');
    setPage(page ?? 1)
  }, [])

  const changePage = (n) => {
    if (n < 1 || n > data.totalPages) return;

    setPage(n)
    setSearchParams({
      page: n
    })
  }
  return (
    <div>
      <div className="product">

        <TitleFeatured label="PC GEARVN - MIỄN PHÍ GIAO HÀNG TOÀN QUỐC" />
        <div className="grid grid-cols-5 gap-3">
          <ProductItem />
        </div>
        <br />
        <TitleFeatured label="LAPTOP GAMING BÁN CHẠY" />
        <div className="grid grid-cols-5 gap-3">
          {/* {data.map((product) => {
                return <ProductItem product={product} key={product.id}/>;
              })} */}
          <ProductItem />
       
        </div>
      </div>
    </div>
  )
}

export default Content