import React from 'react'

const Footer = () => {
  return (
    <div className=''>
      <div className='flex bg-[url("https://theme.hstatic.net/1000026716/1000440777/14/bg-register.png")]  py-[9px] bg-[#dedede] bg-no-repeat gap-96'>
        <div className=''>
          <div className='text-[16px] ml-[70px] pt-[4px]'>Mua hàng online với nhiều ưu đãi hơn tại GEARVN</div>
        </div>
        <div className="flex items-center ">
          <input className=' rounded-tr-[0px]  rounded-br-[0px] h-[30px] outline-[#66afe9] py-[10px] px-[15px] rounded-[3px] text-[13px] w-[370px] ' type="text" placeholder='Nhập email của bạn' />
          <span className=''>
							<button className='hover:opacity-[0.5] focus:outline h-[33px] rounded border-[1px]  focus:shadow focus:outline-[#66afe9]  py-[5px] px-[10px] text-[12px] rounded-tl-[0px] rounded-bl-[0px]  bg-[#e02626] border-[#ccc] text-[#ffffff] rounded-[3px] ' type="submit">Đăng ký</button>
					</span>
        </div>
      </div>
    
    </div>
  )
}

export default Footer
