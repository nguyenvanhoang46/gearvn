import React from 'react'
import { Link, NavLink } from 'react-router-dom';
import { useState, useEffect, useContext, useParams } from 'react';
import { getProduct } from '../../app/services/adminService';
import { Cartcontext } from '../../contexts/cart/Context';
import { useQuery } from 'react-query';
import { useSearchParams } from "react-router-dom";
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

const ProductItem = ({ product }) => {

  // const [data, setData] = useState([]);
  const [page, setPage] = useState(1)
  const [limit, setLimit] = useState(10)
  const { data, isLoading } = useQuery(['GET_PRODUCT_API', page, limit], () => getProduct({ page, limit }))
  let [searchParams, setSearchParams] = useSearchParams();

  // useEffect(() => {
  //   const getAllProduct = async () => {
  //     try {
  //       const data = await getProduct();
  //       setData(data.data);
  //       console.log("hònga", data);
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

  const GlobalState = useContext(Cartcontext);
  const dispatch = GlobalState.dispatch;
  console.log(GlobalState);

  return (
    <>
      {data?.data.map((item, index) => {
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

      <div className="my-[20px] ml-[550px]">
        <div class="bg-white p-4 text-center ">
          <nav aria-label="Page navigation">
            <ul class="inline-flex">
              <li onClick={() => changePage(page - 1)}>
                <button class="h-10 px-5 text-green-600 transition-colors duration-150 rounded-l-lg focus:shadow-outline hover:bg-green-100">
                  <svg class="w-4 h-4 fill-current" viewBox="0 0 20 20"><path d="M12.707 5.293a1 1 0 010 1.414L9.414 10l3.293 3.293a1 1 0 01-1.414 1.414l-4-4a1 1 0 010-1.414l4-4a1 1 0 011.414 0z" clip-rule="evenodd" fill-rule="evenodd"></path></svg>
                </button>
              </li>
              {
                Array(data?.totalPages ?? 1).fill(0).map((_, index) => {
                  if (index + 1 === Number(page)) {
                    return (
                      <li onClick={() => changePage(index + 1)}><button class="h-[30px] mt-1 px-[12px] rounded-[50%] text-white transition-colors duration-150 bg-green-600 border border-r-0 border-green-600 focus:shadow-outline">{index + 1}</button></li>
                    )
                  }

                  return (
                    <li onClick={() => changePage(index + 1)}><button class="h-[30px] px-[12px] ml-1 mt-1 rounded-[50%] text-green-600 transition-colors duration-150 focus:shadow-outline hover:bg-green-100">{index + 1}</button></li>
                  )
                })
              }
              <li onClick={() => changePage(page + 1)}>
                <button class="h-10 px-5 text-green-600 transition-colors duration-150 bg-white rounded-r-lg focus:shadow-outline hover:bg-green-100">
                  <svg class="w-4 h-4 fill-current" viewBox="0 0 20 20"><path d="M7.293 14.707a1 1 0 010-1.414L10.586 10 7.293 6.707a1 1 0 011.414-1.414l4 4a1 1 0 010 1.414l-4 4a1 1 0 01-1.414 0z" clip-rule="evenodd" fill-rule="evenodd"></path></svg>
                </button>
              </li>
            </ul>
          </nav>
        </div>
      </div>
    </>
  )
}

export default ProductItem
