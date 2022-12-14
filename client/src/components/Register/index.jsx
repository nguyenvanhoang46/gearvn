import React from 'react'
import Header from '../Header'
import {Link} from 'react-router-dom'
import {FaUser} from 'react-icons/fa'
import {MdEmail} from 'react-icons/md'
import {BsTelephoneFill} from 'react-icons/bs'
import {RiLockPasswordFill} from 'react-icons/ri'
import Category from '../catergory'
import Footer from '../Footer'

const Register = () => {
  return (
    <>
     <div className='bg-[#f1f0f1]'>
      <Header />  
      <Category />
      </div>
    <div className="container mx-auto text-center mt-10">
      <h1 className='text-[36px] font-medium '>Tạo tài khoản</h1>
      <div className="mt-5 flex text-center justify-center">
        <form className='' action="" method="">
          <div className="flex">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <FaUser />
              </span>
            <input className='w-[230px] py-[17px] px-[12px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="text" placeholder='Họ và tên' />
          </div>
          <div className="flex mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <MdEmail />
              </span>
            <input className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="email" placeholder='Email' />
          </div>
          <div className="flex  mt-5">
              <span className='py-[10px] px-[15px] text-[14px] text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <BsTelephoneFill />
              </span>
            <input className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="text" placeholder='Phone' />
          </div>
          <div className="flex  mt-5">
              <span className='py-[10px] px-[15px] text-[14px]  text-[#555] bg-[#eee] border-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <RiLockPasswordFill />
              </span>
            <input className='w-[230px] py-[17px] px-[15px] text-[14px]  text-[#555] border-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="password" placeholder='Password' />
          </div>
        </form>
      </div>
      <div className="flex gap-8 justify-center mt-8">
			<input className='hover:bg-[black] bg-[#F0F0F0] uppercase hover:text-[white] cursor-pointer py-[7px] px-[14px] text-[14px] font-normal border-[1px] rounded-[4px] ' type="submit" value="Đăng ký" />			
      <div className="hover:bg-[black]  hover:text-[white] py-[7px] px-[14px] rounded-[5px] bg-[#ccc] ">
			  <Link to='/' className="">Quay về</Link>
		  </div>
		  </div>
      <div className="mt-10">
        <Footer />
      </div>
    </div>
    </>
  )
}

export default Register