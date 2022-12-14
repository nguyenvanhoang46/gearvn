import React from 'react'
import Header from '../Header'
import {FaUser} from 'react-icons/fa'
import {MdEmail} from 'react-icons/md'
import {BsTelephoneFill} from 'react-icons/bs'
import {RiLockPasswordFill} from 'react-icons/ri'

const Register = () => {
  return (
    <>
     {/* <Header />    */}
     <div className="container mx-auto flex justify-center ">
        <form action="" method="get">
          <div className="flex">
              <span className='py-[8px] px-[12px] text-[14px]  text-[#555] bg-[#eee] boeder-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <FaUser />
            </span>
            <input className='w-[230px] py-[8px] px-[12px] text-[14px]  text-[#555] boeder-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="text" placeholder='Họ và tên' />
          </div>
          <div className="flex mt-5">
              <span className='py-[8px] px-[12px] text-[14px]  text-[#555] bg-[#eee] boeder-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <MdEmail />
            </span>
            <input className='w-[230px] py-[8px] px-[12px] text-[14px]  text-[#555] boeder-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="email" placeholder='email' />
          </div>
          <div className="flex  mt-5">
              <span className='py-[8px] px-[12px] text-[14px]  text-[#555] bg-[#eee] boeder-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <BsTelephoneFill />
            </span>
            <input className='w-[230px] py-[8px] px-[12px] text-[14px]  text-[#555] boeder-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="text" placeholder='phone' />
          </div>
          <div className="flex  mt-5">
              <span className='py-[8px] px-[12px] text-[14px]  text-[#555] bg-[#eee] boeder-[#ccc] rounded border-[1px] rounded-tr-[0px] rounded-br-[0px] border-r-0 border-t[0px] '>
              <RiLockPasswordFill />
            </span>
            <input className='w-[230px] py-[8px] px-[12px] text-[14px]  text-[#555] boeder-[#ccc] rounded-tl-[0px] rounded-bl-[0px] focus:outline rounded border-[1px] h-[34px] focus:shadow focus:outline-[#66afe9]  ' type="password" placeholder='Password' />
          </div>
        </form>
     </div>
    </>
  )
}

export default Register