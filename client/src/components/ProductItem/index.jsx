import React from 'react'

const ProductItem = ({id, title, price, sale, thumbnail}) => {

  return (
    <>
       <div className="group hover:border-[#F1DF8D] bg-[#FFF] border-[1px] shadow hover:shadow-none relative ">
          <div className="h-[230px] w-full max-h-[363px] ">
            <img className='w-full min-h-[211px] min-w-[196px] cursor-pointer' src="//product.hstatic.net/1000026716/product/hn093w_f885c53fcc5d4b82b3c55b52dd4ce038_large.png" alt="" />
          </div>
          <div className="text-[14px] w-full top-[55%] py-[15px] px-[20px]  text-[#fff] opacity-95 bg-[#656255] hidden group-hover:block absolute z-10">
            <a href="" className='mr-2 font-italic  '><i>Click để xem chi tiết</i></a>
            <a href="" className='py-[7px] px-[12px] bg-[#252525] hover:bg-[#0655A6] rounded'>Đặt hàng</a>
          </div>
          <div className="">
            <h2 className='text-sm m-[10px] '>{title}</h2>
            <div className="pl-[10px] pb-[5px]  ">
              <del className='text-[#888]'>33,490,000₫</del>
              <br />
              <span  className='text-[20px] text-[#ed0000] font-bold '>{price}</span>
            </div>
          </div>
        </div>
    </>
  )
}

export default ProductItem
