import React from 'react'
import { Link, NavLink } from 'react-router-dom';
import { useState, useEffect, useContext, useParams } from 'react';
import { getProduct } from '../../app/services/adminService';
import { Cartcontext } from '../../contexts/cart/Context';

const ProductItem = ({ product }) => {

  const [data, setData] = useState([]);

  useEffect(() => {
    const getAllProduct = async () => {
      try {
        const data = await getProduct();
        setData(data.data);
        console.log("hònga", data);
      } catch (error) {
        console.log(error.message);
      }
    }
    getAllProduct();
  }, []);

  const GlobalState = useContext(Cartcontext);
  const dispatch = GlobalState.dispatch;
  console.log(GlobalState);

  return (
    <>
      {data.map((item, index) => {
        console.log(item.name);
        item.quantity = 1;
        return (
          <div key={index} className="group hover:border-[#F1DF8D] bg-[#FFF] border-[1px] shadow hover:shadow-none relative ">
            <div >
              <div className="h-[230px] w-full max-h-[363px] ">
                <img className='w-full min-h-[211px] min-w-[196px] cursor-pointer' src={item.images.length > 0 ? item.images[0].url : ""} alt="" />
              </div>
              <div className="text-[14px] w-full top-[50%] py-[15px] px-[20px] text-[#fff] bg-opacity-80 bg-[#797565] hidden group-hover:block absolute z-10">
                <Link to={`/productdetail/${item.id}`} className='mr-2 font-italic'><i>Click để xem chi tiết</i></Link>
                <button onClick={() => dispatch({ type: "ADD", payload: item })} className='py-[7px] px-[12px] bg-[#252525] hover:bg-[#0655A6] rounded' >Đặt hàng</button>
              </div>
            </div>
            <div className="mt-5">
              <h2 className='text-sm m-[10px] t-3 '>{item.name}</h2>
              <div className="pl-[10px] pb-[5px]  ">
                <del className='text-[#888]'>{(item.salePrice).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</del>
                <br />
                <span className='text-[20px] text-[#ed0000] font-bold '>{(item.price).toLocaleString('vi', { style: 'currency', currency: 'VND' })}</span>
              </div>
            </div>
          </div>
        )
      })}
     
    </>
  )
}

export default ProductItem
